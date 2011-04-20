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
    }
}
