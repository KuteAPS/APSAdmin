using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using ManagementBLL;
using ManagementCore;
using ManagementModels.OtherModels;
using Models;
using SubSonic;

namespace ManagementAdmin.Controllers
{
    public class SystemConfigController : ManagementController
    {
        #region 用户管理

        // 用户管理UI
        public ActionResult UsersAdmin()
        {
            return View();
        }

        //分页获取用户列表
        public string GetAllUserList(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<VUser>(offset / limit + 1, limit, VUser.Schema.TableName, sort, order));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //删除用户
        public string DelUserList(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<VUser>)JsonHelper.ReturnObject(id, typeof(List<VUser>));
                return new DataHelperBll().DelData<TBasisUser>(TBasisUser.IdColumn, obj.ConvertAll(x => x.Id.ToString()));
            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(returnJson);
            }
        }

        //编辑-新增用户
        public ActionResult AddOrEditUsers(string id)
        {
            GetUserForEdit(id);
            return View();
        }

        //获取所有页面信息，用于用户权限选择
        public string GetAllWebPage()
        {
            return new DataHelperBll().GetDataByCoumJson<VGroupWeb>(VGroupWeb.Schema.TableName, VGroupWeb.Columns.Jurisdiction, -1);
        }

        //编辑用户时选择的用户组列表
        public string GetUserGroup()
        {
            return new DataHelperBll().GetDataByTableJson<TBasisUsersGroup>(TBasisUsersGroup.Schema.TableName);
        }

        //编辑用户时，获取用户信息
        public void GetUserForEdit(string id)
        {
            var user = new DataHelperBll().GetDataByCoumObject<TBasisUser>(TBasisUser.Schema.TableName, TBasisUser.IdColumn.ColumnName, id).FirstOrDefault();
            ViewBag.EditUser = user ?? new TBasisUser();
        }

        //新增/修改
        public string AddOrUpdateUsers(string id, string userName, string userPwd, string email, string telphone, string account, string securityLock, string usersGroup)
        {
            #region 重要字符不能为空

            Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"用户名", userName},
                {"用户密码", userPwd},
                {"账号", account}
            };
            var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
            if (iserr.Success == "error")
            {
                return JsonHelper.GetJsonO(iserr);
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                iserr = DateHelper.IsFormat(email, "mail");
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }
            }

            if (!string.IsNullOrWhiteSpace(telphone))
            {
                iserr = DateHelper.IsFormat(telphone, "tel");
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }
            }

            #endregion


            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {"userName", userName},
                {"userPwd", userPwd},
                {"email", email},
                {"account", account},
                {"telphone", telphone},
                {"securityLock", string.IsNullOrWhiteSpace(securityLock)?0:int.Parse(securityLock)},
                {"havingPage", Request["havingPage"]},
                {"usersGroup", int.Parse(usersGroup)}
            };

            return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisUser), account, dictionary);
        }
        #endregion

        #region 用户组管理

        public ActionResult UsersGroupAdmin()
        {
            return View();
        }

        //分页获取用户组列表
        public string GetAllUserGroupList(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<TBasisUsersGroup>(offset / limit + 1, limit, TBasisUsersGroup.Schema.TableName, sort, order));
            }
            catch (Exception)
            {
                return null;
            }
        }

        //删除页面
        public string DelUserGroupList(string Id)
        {
            try
            {
                var obj = (List<TBasisUsersGroup>)JsonHelper.ReturnObject(Id, typeof(List<TBasisUsersGroup>));
                return new DataHelperBll().DelData<TBasisUsersGroup>(TBasisUsersGroup.IdColumn, obj.ConvertAll(x => x.Id.ToString()));
            }
            catch (Exception ex)
            {
                return JsonHelper.GetJsonO(new WebReturnJsonModel() { Success = "error", JsonMsg = ex.Message });

            }
        }

        //新增/修改
        public string AddOrUpdateUsersGroup(string id, string groupName, string locked)
        {
            try
            {
                #region 重要字符不能为空

                Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"用户组名", groupName}
            };
                var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }

                #endregion

                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("groupName", groupName);
                dictionary.Add("groupLock", string.IsNullOrWhiteSpace(locked) ? 0 : int.Parse(locked));

                return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisUsersGroup), id, dictionary);
            }
            catch (Exception ex)
            {
                return JsonHelper.GetJsonO(new WebReturnJsonModel() { Success = "error", JsonMsg = ex.Message });
            }
        }

        #endregion

        #region 页面管理

        //页面管理UI
        public ActionResult WebPageAdmin()
        {
            return View();
        }

        //分页获取页面列表
        public string GetAllPagedList(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<TBasisWebPage>(offset / limit + 1, limit, TBasisWebPage.Schema.TableName, sort, order));
            }
            catch (Exception)
            {
                return null;
            }
        }

        //删除页面
        public string DelWebPageList(string Id)
        {
            try
            {
                var obj = (List<TBasisWebPage>)JsonHelper.ReturnObject(Id, typeof(List<TBasisWebPage>));
                return new DataHelperBll().DelData<TBasisWebPage>(TBasisWebPage.IdColumn, obj.ConvertAll(x => x.Id.ToString()));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //新增/修改
        public string AddOrUpdateWebPage(string id, string pageName, string pageUrl, int groupId, string locked, string jurisdiction,string showMenu)
        {
            try
            {
                #region 重要字符不能为空

                Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"页面名称", pageName},
                {"页面URL", pageUrl}
            };
                var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }

                #endregion

                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("id", int.Parse(id));
                dictionary.Add("pageName", pageName);
                dictionary.Add("pageUrl", pageUrl);
                dictionary.Add("groupId", groupId);
                dictionary.Add("Locked", string.IsNullOrWhiteSpace(locked) ? -1 : int.Parse(locked));
                dictionary.Add("jurisdiction", string.IsNullOrWhiteSpace(jurisdiction) ? -1 : int.Parse(jurisdiction));
                dictionary.Add("showMenu", string.IsNullOrWhiteSpace(showMenu) ? -1 : int.Parse(showMenu));

                return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisWebPage), id, dictionary);
            }
            catch (Exception ex)
            {
                return JsonHelper.GetJsonO(new WebReturnJsonModel() { Success = "error", JsonMsg = ex.Message });
            }
        }

        //获取页面分组信息
        public string GetWenGroupList()
        {
            return new DataHelperBll().GetDataByTableJson<TBasisWebGroup>(TBasisWebGroup.Schema.TableName);
        }

        #endregion

        #region 页面分组管理

        public ActionResult WebPageGroupsAdmin()
        {
            return View();
        }

        //分页获取页面分组
        public string GetAllWebPageGroups(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<TBasisWebGroup>(offset / limit + 1, limit, TBasisWebGroup.Schema.TableName, sort, order));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //删除页面分组
        public string DelWebPageGroups(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<TBasisWebGroup>)JsonHelper.ReturnObject(id, typeof(List<TBasisWebGroup>));
                return new DataHelperBll().DelData<TBasisWebGroup>(TBasisWebGroup.GroupNameColumn, obj.ConvertAll(x => x.GroupName));
            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(returnJson);
            }
        }

        //新增/修改
        public string AddOrUpdateWebPageGroup(string id, string groupName, string groupIcon, string sort)
        {
            try
            {
                #region 重要字符不能为空

                Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"页面分组名", groupName}
            };
                var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }

                #endregion

                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("groupName", groupName);
                dictionary.Add("groupIcon", groupIcon);
                dictionary.Add("sort", string.IsNullOrWhiteSpace(sort) ? 0 : int.Parse(sort));

                return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisWebGroup), id, dictionary);
            }
            catch (Exception ex)
            {
                return JsonHelper.GetJsonO(new WebReturnJsonModel() { Success = "error", JsonMsg = ex.Message });
            }
        }


        #endregion

        #region 权限请求

        public ActionResult NeedPermissionsAdmin()
        {
            return View();
        }

        //分页获取权限请求列表
        public string GetAllNeedPermissions(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<VUsersNeedPermission>(offset / limit + 1, limit, VUsersNeedPermission.Schema.TableName, sort, order));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //请求驳回,删除请求数据
        public string RemoveNeedPermissions(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<VUsersNeedPermission>)JsonHelper.ReturnObject(id, typeof(List<VUsersNeedPermission>));

                return new UserBll().DelPermissions(obj);

            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(returnJson);
            }
        }

        //同意请求，为其添加授权页面
        public string NeedPermissionsOk(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<VUsersNeedPermission>)JsonHelper.ReturnObject(id, typeof(List<VUsersNeedPermission>));
                return new UserBll().AddPermissions(obj);
            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(returnJson);
            }

        }
        #endregion

        #region 用户信息修改

        public ActionResult UserUpdateMsg()
        {
            ViewBag.EditUser =
                new DataHelperBll().GetDataByCoumObject<TBasisUser>(TBasisUser.Schema.TableName,
                    TBasisUser.IdColumn.ColumnName, ThisUser.Id).FirstOrDefault();
            return View();
        }


        //新增/修改
        public string EditUsers(string userName, string userPwd, string email, string telphone)
        {
            #region 重要字符不能为空

            Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"用户名", userName},
                {"用户密码", userPwd}
            };
            var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
            if (iserr.Success == "error")
            {
                return JsonHelper.GetJsonO(iserr);
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                iserr = DateHelper.IsFormat(email, "mail");
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }
            }

            if (!string.IsNullOrWhiteSpace(telphone))
            {
                iserr = DateHelper.IsFormat(telphone, "tel");
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }
            }


            #endregion


            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {"userName", userName},
                {"userPwd", userPwd},
                {"email", email},
                {"telphone", telphone},
            };

            return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisUser), ThisUser.Account, dictionary);
        }
        #endregion


    }
}