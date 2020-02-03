using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult News()
        {
            Country country = new Country() { Id=1,Name="USA",Population=340000000};
            Country country2 = new Country() { Id = 2, Name = "China", Population = 2000000000 };

            ViewBag.Message = "Weekly news.";

            List<Country> countries = new List<Country>();

            countries.Add(country);
            countries.Add(country2);

            ViewBag.Data = countries;

            return View();
        }
    }
}