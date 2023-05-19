using Practice.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Practice.Models
{
    public class Database
    {
        public Students Students { get; set; }
        public Courses Courses { get; set; }
        public Faculties Faculties { get; set; }
        public Database(){
            string connString = @"Server=DESKTOP-A2SMR1S;Database=UMS_practice;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);

            //If we dont initiate those classes it will be null so we have to initiate thouse classes here.
            Students = new Students(conn);
            Courses = new Courses(conn);
            Faculties = new Faculties(conn);



        }
    }
}