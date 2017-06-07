using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoaspnetmvc.Controllers
{
    public class UserController : Controller
    {
        public string Index() {
            return "Hello, <h3>Worlds</h3>";
        }

        public ActionResult Index1() {
            return View();
        }

        public string Welcome(string name, int id = 1) {
            return HttpUtility.HtmlEncode("Welcome to my world, " + name + ", ID = " + id);
        }
    }
}
