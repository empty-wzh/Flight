using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightWeb.Common
{
    public static class UserHelper
    {


        public static string GetUserName()
        {
            return SessionHelper.GetSession(HttpContext.Current, "user_name");
        }


        public static void SetUserName(HttpContext context, string sessionValue)
        {
            SessionHelper.SetSession(context, "user_name", sessionValue);
        }
    }
}