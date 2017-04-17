using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementBLL;
using ManagementCore;
using Models;

namespace ManagementAdmin.Controllers
{
    public class CustomErrorsController : ManagementController
    {
        #region 权限错误页面提示可申请

        public ActionResult ErrorPermissions(string id)
        {
            ViewBag.PageId = id;
            return View();
        }


        public string NeedPermissions(string userId, string pageId, string content)
        {
            #region 重要字符不能为空

            Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"申请事由", content}
            };
            var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
            if (iserr.Success == "error")
            {
                return JsonHelper.GetJsonO(iserr);
            }

            #endregion

            #region 验证是否已有此页面权限  是否已申请过此页面权限

            var checkResult = new WebPageBll().CheckNeedPermissions(ThisUser.Id.ToString(), pageId);
            if (checkResult.Success.ToLower() != "success")
                return JsonHelper.GetJsonO(checkResult);
            #endregion

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("userId", ThisUser.Id);
            dictionary.Add("pageId", int.Parse(pageId));
            dictionary.Add("content", content);
            dictionary.Add("createtime", DateTime.Now);

            return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisNeedPermission), "", dictionary);
        }

        #endregion


        public ActionResult Error404()
        {
            return View();
        }
    }
}