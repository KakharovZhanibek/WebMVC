using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class MyController : Controller
    {
        [HttpGet]
        public ActionResult Index(string id1, string id2)
        {
            ViewData["Result"] = id1 + " " + id2;
            return View();
            //string st = string.Format("{0} - {1}", "Hello", "world");
        }
    }
}