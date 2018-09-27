using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.API.Controllers
{
    public class HomeController : Controller
    {
        // GET: API/Home
        public ActionResult Index()
        {
            return Content("空API");
        }
    }
}