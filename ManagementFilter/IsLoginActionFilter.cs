using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementCore;

namespace ManagementFilter
{
    /// <summary>
    /// 监测是否有用户登录信息,用户登录页面，监测用户已登录则跳转到系统首页
    /// </summary>
    public class IsLoginActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string cookieStr = CookieHelper.ReadCookie("UCookie", filterContext.HttpContext.Request);
                string controller = filterContext.HttpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
                string action = filterContext.HttpContext.Request.RequestContext.RouteData.Values["action"].ToString();

                if (!string.IsNullOrWhiteSpace(cookieStr) && controller + "/" + action == "Home/Login")
                {
                    filterContext.Result = new RedirectResult("/Home/Index");
                }

                if (string.IsNullOrWhiteSpace(cookieStr) && controller + "/" + action != "Home/Login")
                {
                    filterContext.Result = new RedirectResult("/Home/Login");
                }
            }
            catch (Exception)
            {
                throw;
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
