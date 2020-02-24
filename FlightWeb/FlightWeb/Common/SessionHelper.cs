using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightWeb.Common
{
    public static class SessionHelper
    {

        public static void SetSession(HttpContext httpContext, string key, string value)
        {
            httpContext.Session[key] = value;
        }

        public static string GetSession(HttpContext httpContext, string key)
        {
            return httpContext.Session[key] == null ? string.Empty : HttpContext.Current.Session[key].ToString();
        }

        public static void ClearSession(HttpContext httpContext, string key)
        {
            httpContext.Session[key] = null;
        }
    }
}