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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DodajKoment()
        {
            return View();
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
            ViewData["komentarze"] = db_gosc.get_comments(id);
            return View();
        }

        public ActionResult wybierz(string tytul_id) 
        {
            if (tytul_id != null)
            {
                string id = string.Empty;
                for (int i = tytul_id.Length-1; i> 0 &&tytul_id[i] != '_'; --i)
                    id += tytul_id[i];

                int parseid = 0;
                if (int.TryParse(id, out parseid))
                {
                    return showpost(parseid);
                }
                else
                {
                    ViewData["error"] = "wystapil blad parsowania";
                    return View();
                }
            }
            return View("Nie podano danych");
        }
    }
}
