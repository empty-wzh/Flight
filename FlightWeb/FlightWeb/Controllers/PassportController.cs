using FlightWeb.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightWeb.Controllers
{
    public class PassportController : Controller
    {
        

        public ActionResult Login()
        {
            return View();
        }


        public JsonResult DoLogin(string userName, string password)
        {
            //这里验证用户名密码是否正确
            //用户信息
            UserHelper.SetUserName(System.Web.HttpContext.Current, userName);
            return Json(new { result = true, errorMsg = "" });
        }


        public JsonResult DoLogout(string userName, string password)
        {
            //这里验证用户名密码是否正确
            //用户信息
            SessionHelper.ClearSession(System.Web.HttpContext.Current, "user_name");
            return Json(new { result = true, errorMsg = "" });
        }
    }
}