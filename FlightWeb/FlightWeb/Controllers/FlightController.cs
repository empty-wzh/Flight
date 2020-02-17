using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightWeb.Controllers
{
    public class FlightController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 
    }
}