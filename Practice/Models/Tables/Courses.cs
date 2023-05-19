using Practice.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practice.Models.Tables
{
    public class Courses
    {
        SqlConnection conn;
        public Courses(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Course s)
        {

        }

        public Course Get(int Id)
        {
            return null;

        }
        public List<Course> GetAll()
        {
            return null;
        }
    }
}