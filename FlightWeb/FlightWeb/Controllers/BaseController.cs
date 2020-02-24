using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FlightWeb.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            //验证用户是否已登录
            string sessionUserName = FlightWeb.Common.UserHelper.GetUserName();
            if (string.IsNullOrEmpty(sessionUserName))
            {
                //string userid = requestContext.HttpContext.Session["user_id"].ToString();  
                //string user_CompID = requestContext.HttpContext.Session["user_CompID"].ToString();  
                //string user_name = requestContext.HttpContext.Session["user_name"].ToString();  
                //HttpContext.Request.IsAuthenticated = true;
                //Session["user_name"] = AppCookieHelper.GetCookieValue("user_name");
                //如果没有登录，跳转到登录页
                requestContext.HttpContext.Response.Redirect("/Passport/Login");
            }
            else
            {
                //如果已经登录，不做任何操作，正常跳转到请求页
                //Request.IsAuthenticated = false;
                //非登录用户跳转  
                //requestContext.HttpContext.Response.Redirect("/Account/Login");
            }
        }
    }
}