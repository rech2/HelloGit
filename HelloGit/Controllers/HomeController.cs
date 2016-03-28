using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloGit.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Response.Write("<h1>This is Git-Hub</h1>");
        }
        public ActionResult Index()
        {
            Response.Write("<h3>This is the changes</h3>")
        }
    }
}
