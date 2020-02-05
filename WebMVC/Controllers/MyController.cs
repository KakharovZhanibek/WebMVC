using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class MyController : Controller
    {
        //[HttpGet]
        //public ActionResult Index(string id1, string id2)
        //{
        //    ViewData["Result"] = id1 + " " + id2;
        //    return View();
        //    //string st = string.Format("{0} - {1}", "Hello", "world");
        //}

        [HttpGet]
        public ActionResult Index(string id)
        {
            return View();
        }
        [HttpPost]
        public List<string> PostTest(Country country)
        {
            List<string> countries = new List<JObject>();
            for (int i = 0; i < 5; i++)
            {
                countries.Add(JsonConvert.SerializeObject(country));
                
            }
            
            IEnumerable<Country> countriesAsEnumerable = countries.AsEnumerable();
            return countriesAsEnumerable;
        }
    }
}