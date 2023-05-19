using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models.Entity;
using System.Data.SqlClient;
using Practice.Models;

namespace Practice.Controllers
{
    public class Student2Controller : Controller
    {
        // GET: Student2
        public ActionResult Index()
        {
            Database db = new Database();
           var students2=db.Students.GetAll();
            
            return View(students2);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student2 s1)
        {
            //@"Server=DESKTOP-A2SMR1S;Database=UMS_practice;User Id=sa;Password=1234";
            Database db = new Database();
            db.Students.Add(s1);
            return RedirectToAction("Index");
            
        }
    }
}