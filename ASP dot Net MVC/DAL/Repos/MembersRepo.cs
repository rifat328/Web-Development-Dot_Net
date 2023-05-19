using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepo : Repo, IRepo<Members, int, bool>
    {

        public bool Delete(int id)
        {
            var data = db.News.Find(id);
            if (data != null)
            {
                db.News.Remove(data);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Members> Get()
        {
            return db.News.ToList();
        }

        public Members Get(int id)
        {
            return db.News.Find(id);
        }

        public bool Insert(Members obj)
        {
            db.News.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Members obj)
        {
            var exst = db.News.Find(obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
