using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ViewBag.Today = DateTime.Now.ToLongDateString();
            ViewBag.Title = "Index of Hello";
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "ASP.NET MVC Training";
            return View();
        }

        // [Route("/Company")]
        public ActionResult Company()
        {
            ViewBag.Message = "iNoryaSoft";
            return View();
        }
    }
}