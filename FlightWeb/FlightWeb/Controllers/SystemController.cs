using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightWeb.Controllers
{
    public class SystemController : BaseController
    {
        // GET: System
        public ActionResult Index()
        {
            return View();
        }
    }
}