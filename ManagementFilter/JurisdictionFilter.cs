using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementCore;
using ManagementDAL;
using Models;

namespace ManagementFilter
{
    public class JurisdictionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

                string cookieStr = CookieHelper.ReadCookie("UCookie", filterContext.HttpContext.Request);
                var nowUser = (VUser)JsonHelper.ReturnObject(cookieStr, typeof(VUser));


                string controller = filterContext.HttpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
                string action = filterContext.HttpContext.Request.RequestContext.RouteData.Values["action"].ToString();

                #region 为防止恶意注入，采取从数据库获取页面ID
                var web = new TBasisWebPageDAL().GetTBasisWebPage($"{controller}/{action}");
                #endregion

                if (web == null)
                    return;

                string nowpageid = web.Id.ToString();

                bool notJurisdiction = nowUser.HavingPage.Split(',').Any(str => str == nowpageid);

                if (!notJurisdiction)
                {
                    filterContext.Result = new RedirectResult("/CustomErrors/ErrorPermissions");
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
