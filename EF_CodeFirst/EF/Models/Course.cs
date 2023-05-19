using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    public class Course
    {
        public int C_Id { get; set; }

        public string C_Name { get; set; }
        public string C_Code { get; set; }
        public string C_Department { get; set; }
        public int Cradit { get; set; }
    }
}