
using System.Web.Mvc; 
using Models;

namespace ManagementCore
{
    [JurisdictionFilter]
    public class ManagementController : Controller
    {
        /// <summary>
        ///当前登陆用户信息 
        /// </summary>
        public VUser ThisUser
        {
            get
            {
                string userJson = CookieHelper.ReadCookie("UCookie", Request);
                return (VUser)JsonHelper.ReturnObject(userJson, typeof(VUser));
            }

        }
    }
}
