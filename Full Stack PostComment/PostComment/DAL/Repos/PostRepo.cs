using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class PostRepo : Repo, IRepo<Post, int, bool>
    {
        public bool Create(Post obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            return db.Posts.ToList();
        }

        public Post Read(int id)
        {
            return db.Posts.Find(id);
        }

        public bool Updade(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
