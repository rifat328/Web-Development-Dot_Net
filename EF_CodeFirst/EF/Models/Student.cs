using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string UniId { get; set; }
        public string Department { get; set; }
        public float? Cgpa { get; set; }

    }
}