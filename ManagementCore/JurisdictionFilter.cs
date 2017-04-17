using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementCore;
using ManagementDAL;
using Models;

namespace ManagementCore
{
    public class JurisdictionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

                string cookieStr = CookieHelper.ReadCookie("UCookie", filterContext.HttpContext.Request);

                string controller = filterContext.HttpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
                string action = filterContext.HttpContext.Request.RequestContext.RouteData.Values["action"].ToString();
                if (cookieStr == null&& $"{controller}/{action}".ToLower()!= "home/login")
                    filterContext.Result = new RedirectResult("/Home/Login");

                var nowUser = (VUser)JsonHelper.ReturnObject(cookieStr, typeof(VUser));

                nowUser = new DataHelper().GetDataByCloum<VUser>(VUser.Schema.TableName, VUser.Columns.Id, nowUser.Id).FirstOrDefault();

                #region 为防止恶意注入，采取从数据库获取页面ID

                var web = new TBasisWebPageDAL().GetTBasisWebPage($"{controller}/{action}");

                #endregion

                if (web == null || web.Jurisdiction == 0)
                    return;

                string nowpageid = web.Id.ToString();
                bool notJurisdiction = true;
                if (!string.IsNullOrWhiteSpace(nowUser.HavingPage))
                {
                    notJurisdiction = nowUser.HavingPage.Split(',').Any(str => str == nowpageid);
                }

                if (!notJurisdiction)
                {
                    filterContext.Result = new RedirectResult($"/CustomErrors/ErrorPermissions/{nowpageid}.html");
                }
            }
            catch (Exception)
            {
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}
