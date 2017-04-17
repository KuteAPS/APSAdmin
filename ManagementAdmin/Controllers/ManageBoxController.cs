using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementBLL;
using ManagementCore;
using ManagementModels.OtherModels;
using Models;

namespace ManagementAdmin.Controllers
{
    public class ManageBoxController : ManagementController
    {
        #region 消息列表

        // GET: MailBox
        public ActionResult Index()
        {
            return View();
        }

        //获取未读列表
        public string GetManagetList(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<VManageListNoRead>(offset / limit + 1, limit, VManageListNoRead.Schema.TableName, sort, order));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ActionResult ReadOldMsgList()
        {
            return View();
        }

        //获取已读列表
        public string GetOldMsg(int limit, int offset, string sort, string order)
        {
            try
            {
                return JsonHelper.GetJsonO(new DataHelperBll().GetDataByPage<VManageListRead>(offset / limit + 1, limit, VManageListRead.Schema.TableName, sort, order));
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        //删除选中信息
        public string DelMsgs(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<VManageListRead>)JsonHelper.ReturnObject(id, typeof(List<VManageListRead>));
                return new DataHelperBll().DelData<TBasisSystemManageBox>(TBasisSystemManageBox.IdColumn, obj.ConvertAll(x => x.Id.ToString()));
            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(returnJson);
            }

        }

        //全部标记为已读
        public string SelectIsRead(string id)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                var obj = (List<VManageListRead>)JsonHelper.ReturnObject(id, typeof(List<VManageListRead>));
                return new DataHelperBll().UpdateOneCloum(TBasisSystemManageBox.Schema.TableName,
                     TBasisSystemManageBox.RedingColumn.ColumnName, "1", TBasisSystemManageBox.IdColumn.ColumnName, obj.ConvertAll(x => x.Id.ToString()),
                     "or");
            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(returnJson);
        }

        #endregion

        #region 消息展示

        public ActionResult SystemMsgShow(string id)
        {
            GetMsgById(id);
            return View();
        }

        //获取单条信息
        public void GetMsgById(string id)
        {
            try
            {
                var obj = new DataHelperBll().GetDataByCoumObject<TBasisSystemManageBox>(TBasisSystemManageBox.Schema.TableName,
                    TBasesNotice.IdColumn.ColumnName, id).FirstOrDefault();
                ViewBag.msg = obj ??
                              new TBasisSystemManageBox() { CreateTime = DateTime.Now, Title = "消息获取异常", Content = "消息无效，请返回列表刷新后查看" };

                if (obj != null)
                {
                    new DataHelperBll().AddOrUpdateDataById(typeof(TBasisSystemManageBox), obj.Id.ToString(),
                        new Dictionary<string, object>() { { TBasisSystemManageBox.RedingColumn.ColumnName, obj.Reding + 1 } });
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        #endregion
    }
}