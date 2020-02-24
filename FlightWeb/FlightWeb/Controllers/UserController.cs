using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightWeb.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserPrivileges()
        {
            return View();
        }
        public ActionResult PrivilegesGroup()
        {
            return View();
        }

        public ActionResult Organization()
        {
            return View();
        }
    }
}