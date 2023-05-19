using Practice.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practice.Models.Tables
{
    public class Faculties
    {
        SqlConnection conn;
        public Faculties(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Facultie s)
        {

        }

        public Facultie Get(int Id)
        {
            return null;

        }
        public List<Facultie> GetAll()
        {
            return null;
        }
    }
}