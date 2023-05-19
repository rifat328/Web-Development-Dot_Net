using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models.Entity
{
    public class Student2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public float? Cgpa { get; set; }
    }
}