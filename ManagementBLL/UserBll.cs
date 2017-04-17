using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ManagementCore;
using ManagementDAL;
using ManagementModels;
using ManagementModels.OtherModels;
using Models;

namespace ManagementBLL
{
    public class UserBll
    {
        private WebReturnJsonModel ReturnJson { get; set; }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uAccount">账号</param>
        /// <param name="uPwd">密码</param>
        /// <param name="response">上下文信息</param>
        /// <returns></returns>
        public string UsersLogin(string uAccount, string uPwd, HttpResponseBase response)
        {
            try
            {
                var users = new TBasisUserDAL().GetUsers(uAccount, uPwd);
                if (users != null && users.Count == 1)
                {
                    if (users.First().GroupLock == 0)
                    {
                        if (users.First().SecurityLock == 0)
                        {
                            //用户成功登录缓存Cookie
                            if (CookieHelper.SaveCookie("UCookie", JsonHelper.GetJsonO(users.First()), response))
                            {
                                return "登录成功,正在跳转...";
                            }
                            else
                            {
                                return "登录成功,Cookie写入失败！";
                            }
                        }
                        else
                        {
                            return "用户已锁定,暂不能使用,请联系管理";
                        }
                    }
                    else
                    {
                        return "您所在的用户组已锁定,暂不能使用,请联系管理";
                    }
                }
                else
                {
                    return "用户登录失败,请检查用户名或密码";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        /// <summary>
        /// 用户退出后，清除本地Cookie
        /// </summary>
        /// <param name="response"></param>
        /// <param name="request"></param>
        public static void SignOut(HttpResponseBase response, HttpRequestBase request)
        {
            try
            {
                CookieHelper.DeleteCookie("UCookie", request, response);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 处理权限申请  通过
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string AddPermissions(List<VUsersNeedPermission> list)
        {
            ReturnJson = new WebReturnJsonModel();
            try
            {
                foreach (var permission in list)
                {

                    //修改用户的权限信息
                    TBasisUser user = new TBasisUser(permission.Account);
                    if (string.IsNullOrWhiteSpace(user.HavingPage))
                    {
                        user.HavingPage = permission.PageID.ToString();
                    }
                    else
                    {
                        if (user.HavingPage.Split(',').ToList().FindAll(x => x == permission.PageID.ToString()).Count < 1)
                            user.HavingPage = user.HavingPage + "," + permission.PageID;
                    }
                    user.Save();

                    //删除用户的请求信息
                    new DataHelperBll().DelData<TBasisNeedPermission>(TBasisNeedPermission.IdColumn, permission.Id);

                    //增加到用户的消息
                    new TBasisSystemManageBox()
                    {
                        SendUserId = 94,
                        RecipientUserID = user.Id,
                        Title = $"请求开通页面的权限管理员受理通知消息",
                        Content = ManageTemp.PermissionsMsg(user.UserName, permission.CreateTime.ToString("yyyy-MM-dd"), permission.PageName, "请求通过", "13212345678"),
                        CreateTime = DateTime.Now
                    }.Save();

                }


                ReturnJson.Success = "success";
                ReturnJson.JsonMsg = "处理成功，无异常";
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(ReturnJson);
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }


        /// <summary>
        /// 处理  权限申请  驳回
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string DelPermissions(List<VUsersNeedPermission> list)
        {
            try
            {
                ReturnJson = new WebReturnJsonModel();
                int success = 0;
                string error = string.Empty;
                foreach (var vUsersNeedPermission in list)
                {
                    if (
                        new DataHelperBll().DelData<TBasisNeedPermission>(TBasisNeedPermission.IdColumn,
                            vUsersNeedPermission.Id).Success != "error")
                    {
                        //增加到用户的消息
                        new TBasisSystemManageBox()
                        {
                            SendUserId = 94,
                            RecipientUserID = vUsersNeedPermission.UserID,
                            Title = $"请求开通页面的权限管理员受理通知消息",
                            Content =
                                ManageTemp.PermissionsMsg(vUsersNeedPermission.UserName,
                                    vUsersNeedPermission.CreateTime.ToString("yyyy-MM-dd"),
                                    vUsersNeedPermission.PageName, "请求被驳回", "13212345678"),
                            CreateTime = DateTime.Now
                        }.Save();
                        success++;
                    }
                    else
                    {
                        error += vUsersNeedPermission.PageName + ",";
                    }
                }

                if (success == list.Count)
                {
                    ReturnJson.Success = "success";
                    ReturnJson.JsonMsg = $"执行成功,共{success}条受影响";
                }
                else if (success > 0)
                {
                    ReturnJson.Success = "success";
                    ReturnJson.JsonMsg = $"执行存在异常,异常页面：{error.Substring(0, error.Length - 1)}";
                }
                else
                {
                    ReturnJson.Success = "error";
                    ReturnJson.JsonMsg = "执行失败,请刷新后重新操作";
                }
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }

            return JsonHelper.GetJsonO(ReturnJson);
        }

        /// <summary>
        /// 获取当前用户的可用菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserMenus(int id)
        {
            try
            {
                string webs = new DataHelperBll().GetDataByCoumObject<TBasisUser>(TBasisUser.Schema.TableName, TBasisUser.IdColumn.ColumnName, id).First().HavingPage;
                //初始化菜单Html字符
                string menu = "";

                //获取不需要授权的页面
                List<VGroupWeb> list = new DataHelperBll().GetDataByCoumObject<VGroupWeb>(VGroupWeb.Schema.TableName,
                    VGroupWeb.Columns.Jurisdiction, "0");

                if (!string.IsNullOrWhiteSpace(webs))
                {
                    //获取用户授权的页面集合
                    list.AddRange(new DataHelperBll().GetDataByCoumObj<VGroupWeb>(VGroupWeb.Schema.TableName, VGroupWeb.Columns.Id, webs.Split(',').ToList(), "or"));
                }
                //移除有锁的页面
                list.RemoveAll(x => x.Locked == 0||x.ShowMenu==-1);

                //获取已有的页面分组
                var keys = list.OrderBy(x => x.Sort).GroupBy(x => x.GroupName);

                foreach (var key in keys)
                {
                    menu += $@"<li>
                                <a href='#'><i class='{list.Find(x => x.GroupName == key.Key).GroupIcon}'></i> <span class='nav-label'>{key.Key} </span><span class='fa arrow'></span></a>
                                 <ul class='nav nav-second-level'>";

                    var itemMenu = list.FindAll(x => x.GroupName == key.Key);
                    menu = itemMenu.Aggregate(menu, (current, vGroupWeb) => current + $@"<li><a class='J_menuItem' href='/{vGroupWeb.PageUrl}'>{vGroupWeb.PageName}</a></li>");

                    menu += @"</ul>
                           </li>";
                }
                return menu;
            }
            catch (Exception)
            {
                throw;
            }

        }



    }
}
