using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class GoscRepository
    {
        bazaDataContext db = new bazaDataContext();
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
                k.id_posta = post.id;
             
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