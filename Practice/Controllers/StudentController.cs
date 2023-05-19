using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult Index()
        {
            Student s1 = new Student() { Name = "Rifat Hossain", Dob = "08/10/1998", Id = "20-42461-1" };

            return View(s1);
        }

        public ActionResult Lists()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student s2 = new Student()
                {
                    Name = "Rifat Hossain"+" "+i,
                    Id = "20-42461-" + i,
                    Dob = "08/10/199" + " " + i
                };
                students.Add(s2);
            }
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateSubmit()
        {
            Student s3 = new Student();
            //HttpRequestBase class , instance name  Request 
            //put name field identifier of form
            s3.Name = Request["name"];
            s3.Id = Request["id"];
            s3.Dob = Request["dob"];
            return View(s3);
        }

        //next approach form collection obj
        public ActionResult CreateSubmit2(FormCollection form)
        {
            Student s3 = new Student();
            s3.Name = form["name"];
            s3.Id = form["id"];
            s3.Dob = form["dob"];
            return View(s3);
            
        }

        //Approach 3 from direct variable : peramiter names as form names , int? syntex made variable nullable 
        public ActionResult CreateSubmit3(string name,string id,string dob,int? abc)
        {
            Student s3 = new Student();
            s3.Name = name;
            s3.Id = id;
            s3.Dob = dob;
            return View(s3);
        }

        //method 4 : object Model Biend , in a form have same name of input field related to Model class , object will biend

        public ActionResult Create2()
        {
            return View();
        }
        public ActionResult CreateSubmit4(Student s4)
        {
            return View(s4);
        }
    }
}