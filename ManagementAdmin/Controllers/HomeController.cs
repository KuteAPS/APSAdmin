using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ManagementBLL;
using ManagementCore;
using ManagementDAL;

namespace ManagementAdmin.Controllers
{
    public class HomeController : ManagementController
    {
        [IsLoginActionFilter]
        public ActionResult Index()
        {
            ViewBag.ThisUser = ThisUser;
            ViewBag.Menus = new UserBll().GetUserMenus(ThisUser.Id);
            return View();
        }


        [IsLoginActionFilter]
        public ActionResult Login()
        {
            return View();
        }

        public string CheckUsers(string uAccount, string uPwd)
        {
            try
            {
                return new UserBll().UsersLogin(uAccount, uPwd, Response);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string NoReadMsgs()
        {
            Response.ContentType = "text/event-stream";
            return "data:"+ManageBoxBll.GetManageCount(ThisUser.Id.ToString())+"\n\n";
        }

        public void SignOut()
        {
            UserBll.SignOut(Response, Request);
            Response.Redirect("/Home/Login");
        }
    }
}