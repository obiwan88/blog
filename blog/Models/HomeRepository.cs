using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class HomeRepository
    {
        bazaDataContext db = new bazaDataContext();

        public IEnumerable<Post> GetPost()
        {
            IEnumerable<Post> lista =
             (from p in db.Posts
              where p.status == 1
              orderby p.data_dodania descending
              select p).ToList<Post>();
            return lista;
        }
        public IEnumerable<Komentarz> GetKomentarz()
        {
            IEnumerable<Komentarz> lista =
             (from k in db.Komentarzs
              where k.status == 1
              orderby k.data_dodania descending
              select k).ToList<Komentarz>();
            return lista;
        }

    }
}