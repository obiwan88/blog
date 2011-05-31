using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Models;

namespace blog.Controllers
{
    public class GoscController : Controller
    {
        GoscRepository db_gosc = new GoscRepository();
        HomeRepository hr = new HomeRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DodajKoment()
        {
            KlasaPomocniczaDodajKoment obiekt = new KlasaPomocniczaDodajKoment();

            return View(obiekt);
        }

        [HttpPost]
        public ActionResult DodajKoment(KlasaPomocniczaDodajKoment obiekt)
        {
            if (db_gosc.InsertKomentarz(obiekt) == true)
            {
                ViewData["action"] = "Komentarz został dodany";
            }
            else
            {
                
                ViewData["action"] = "Komentarz nie został dodany";
            }
            
            return View(obiekt);
        }

        public ActionResult showpost(int id)
        {
            ViewData["post"] = db_gosc.get_post(id);
             ViewData["klista"] = hr.GetKomentarz();
            return View();
        }

        public ActionResult showKoment(int id) 
        {
            ViewData["komentarze"] = db_gosc.get_comments(id);
           
            return View();
        }

        public ActionResult tytul(string tytul) 
        {
            if (tytul != null)
            {
                ViewData["tytul"] = db_gosc.getPostByTitle(tytul);
                ViewData["klista"] = db_gosc.get_comments(tytul); 
                
            }
            return View();
        }
        public ActionResult data(int year, int month, int day) 
        {
            DateTime dt = new DateTime(year, month, day);
               ViewData["PostsDate"] = db_gosc.GetPostByDate(dt);
              
               return View();
        }

    }
}
