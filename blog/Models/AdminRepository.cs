using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class AdminRepository
    {
        bazaDataContext db = new bazaDataContext();

        public bool InsertPost(KlasaPomocnicza NowyObiekt)
        {
            try
            {
                Post p = new Post();
                p.data_modyfikacji = NowyObiekt.data_modyfikacji;
                p.data_dodania = NowyObiekt.data_dodania;
                p.tresc = NowyObiekt.tresc;
                p.tytul = NowyObiekt.tytul;
                p.status = 0;

                db.Posts.InsertOnSubmit(p);
                db.SubmitChanges();

                Tag t = new Tag();
                t.id_posta = p.id;
                t.description = NowyObiekt.description;
                t.keywords = NowyObiekt.keywords;

                db.Tags.InsertOnSubmit(t);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ) { return false; }
        }

        public Post edytuj(int id)
        {
            return db.Posts.Single(p => p.id == id);
        }

        public bool ZapiszZmiany(Post new_post) 
       {
          try{
              Post post = db.Posts.Single(p => p.id == new_post.id);
            post.tytul = new_post.tytul;
            post.tresc = new_post.tresc;
            post.data_dodania = DateTime.Now;
            db.SubmitChanges();
            return true;
            
          }
            catch(Exception) {return false;}
            
        }

        public bool UsunKomentarze(int idPostu) 
        {
            try
            {
                IEnumerable<Komentarz> doUsuniecia =
                (from k in db.Komentarzs
                 where k.id_posta == idPostu
                 select k
                );
                db.Komentarzs.DeleteAllOnSubmit(doUsuniecia);
                db.SubmitChanges();
                return true;
            }
            catch (Exception) { return false;
            }
        }

        public bool UsunKomentarz(int id)
        {
            try
            {
                Komentarz  doUsuniecia =
                (from k in db.Komentarzs
                 where k.id_posta == id
                 select k
                ).First();
                db.Komentarzs.DeleteOnSubmit(doUsuniecia);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UsunTagiPostu(int idPostu)
        {
            try
            {
                Tag t = (
                    from tag in db.Tags
                    where tag.id_posta == idPostu
                    select tag
                    ).First();
                db.Tags.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool UsunPost(int d_id)
        {
            try
            {
                if (UsunKomentarze(d_id) && UsunTagiPostu(d_id))
                {
                    Post doKasacji =
                       (from p in db.Posts
                        where p.id == d_id
                        select p).First();
                    db.Posts.DeleteOnSubmit(doKasacji);
                    db.SubmitChanges();

                    return true;
                }
                else return false;
            }
            catch (Exception) { return false; }
        }

    }
}