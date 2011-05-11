using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class GoscRepository
    {
        bazaDataContext db = new bazaDataContext();

        public IEnumerable<Post> get_post(int id)
        {
            return (from poscik in db.Posts
                    where poscik.status == 1 && poscik.id == id
                    orderby poscik.data_dodania descending
                    select poscik).ToList<Post>();
        }

        public IEnumerable<Komentarz> get_comments(int id)
        {
            return (from komentarzyki in db.Komentarzs
                    where komentarzyki.status == 1 && komentarzyki.id_posta == id
                    orderby komentarzyki.data_dodania descending
                    select komentarzyki).ToList<Komentarz>();
        }
        
        public Post edytuj(int id)
        {
            return db.Posts.Single(p => p.id == id);
        }
        public bool InsertKomentarz(KlasaPomocniczaDodajKoment NowyObiekt)
        {
            try 
            {
                
                Post post = (from p in db.Posts
                 where p.id == NowyObiekt.id_posta
                 select p).First();
              
             
                Komentarz k = new Komentarz();
                k.id = NowyObiekt.id;
                k.id_posta = NowyObiekt.id_posta;
             
                k.data_dodania = NowyObiekt.data_dodania;
                k.tresc = NowyObiekt.tresc;
                k.autor = NowyObiekt.autor;
                k.status = 0;
                k.Post = post;

                db.Komentarzs.InsertOnSubmit(k);
                db.SubmitChanges();

                 return true;
            }
            catch (Exception) { return false; }
        }
       
    }
}