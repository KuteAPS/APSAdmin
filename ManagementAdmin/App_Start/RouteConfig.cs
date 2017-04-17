using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ManagementAdmin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 "Default",
                 "{controller}/{action}",
                 new { controller = "Home", action = "Index" }
            );


            routes.MapRoute(
              "OneID", // 路由名称    
              "{controller}/{action}/{id}.html"// 带有参数的 URL    
            );
        }
    }
}
