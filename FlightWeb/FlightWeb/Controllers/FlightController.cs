using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightWeb.Controllers
{
    public class FlightController : BaseController
    {
        public ActionResult Index() 
        {
            return View();
        } 
    }
}