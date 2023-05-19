using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
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

        public ActionResult List()
        {
            string[] names = new string[5]; 
            string[] id = new string[5];
            names[0] = "Rifat";
            names[1] = "Sifat";
            names[2] = "Himel";
            names[3] = "Aub Bakker";
            names[4] = "Himu";
            id[0] = "20-42461-1";
            id[1] = "20-42462-1";
            id[2] = "20-42463-1";
            id[3] = "20-42464-1";
            id[4] = "20-42465-1";
           

            ViewBag.Names = names;
            ViewBag.Id = id;
            return View();

        }
    }
}