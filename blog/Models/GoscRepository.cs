using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class GoscRepository
    {
        bazaDataContext db = new bazaDataContext();

        public Post get_post(int id)
        {
            return (from poscik in db.Posts
                    where poscik.status == 1 && poscik.id == id
         
                    select poscik).FirstOrDefault();
        }

        public Komentarz get_comments(int id)
        {
            return (from komentarzyki in db.Komentarzs
                    where komentarzyki.status == 1 && komentarzyki.id_posta == id
         
                    select komentarzyki).FirstOrDefault();
        }

        public List<Komentarz> get_comments(string tytul)
        {
            Post post = getPostByTitle(tytul);

            List<Komentarz> komentarze =  (from komentarzyki in db.Komentarzs
                    where komentarzyki.status == 1 && komentarzyki.id_posta == post.id
                    select komentarzyki).ToList();
            return komentarze;
        }

        public Post getPostByTitle(string tytul)
        {
            Post post= (from p in db.Posts
                      where p.tytul.CompareTo(tytul) == 0
                      select p).FirstOrDefault();
            return post;
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
        public List<Post> GetPostByDate(DateTime date) 
        {
            return (from p in db.Posts
                    where p.data_dodania == date
                    orderby p.data_dodania descending
                    select p).ToList();         
        }
       
    }
}