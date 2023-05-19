using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class UserRepo : Repo, IRepo<User, string, User>
    {
        public User Create(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<User> Read()
        {
           return db.Users.ToList() ;
        }

        public User Read(string id)
        {
            return db.Users.Find(id);
        }

        public User Updade(User obj)
        {
            var ex = Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
