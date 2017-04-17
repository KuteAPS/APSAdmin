using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementCore;

namespace ManagementAdmin.Controllers
{
    public class ToolController : ManagementController
    {
        // GET: Tool
        public ActionResult FormBuilder()
        {
            return View();
        }

        public ActionResult FontAwesome()
        {
            return View();
        }
        
        public ActionResult Glyphicon()
        {
            return View();
        }

        public ActionResult TextDiff()
        {
            return View();
        }


        public ActionResult Spinners()
        {
            return View();
        }
    }
}