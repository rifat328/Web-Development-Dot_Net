using Practice.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practice.Models.Tables
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Student2 s)
        {
            string query = String.Format("Insert into Students values ('{0}','{1}','{2}',0.0)", s.Name, s.Dob, s.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public Student2 Get(int Id)
        {
            return null;

        }
        public List<Student2> GetAll()
        {
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Student2> students2 = new List<Student2>();
            while (reader.Read())
            {
                Student2 s = new Student2
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Cgpa = (float)reader.GetDouble(reader.GetOrdinal("Cgpa"))
                };
                students2.Add(s);
            }
            conn.Close();
            return students2;
        }
    }
}