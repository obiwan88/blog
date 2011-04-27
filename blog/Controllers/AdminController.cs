using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Models;

namespace blog.Controllers
{
    public class AdminController : Controller
    {
        AdminRepository db_admin = new AdminRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dodaj() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dodaj(KlasaPomocnicza obiekt) 
        {
            if (db_admin.InsertPost(obiekt) == true)
            {
                ViewData["action"] = "Post został dodany";
            }
            else 
            {

                ViewData["action"] = "Post nie został dodany";
            }

            return View(obiekt);
        }

        public ActionResult edytuj(int id = 0)
        {
            
            ViewData["post"] = db_admin.edytuj(id);

            return View();
        }

        [HttpPost]
        public ActionResult edytuj(Post post)
        {
            ViewData["post"] = db_admin.edytuj(post.id);
            if (db_admin.ZapiszZmiany(post))
            {
                ViewData["alert"] = "zmiany ok";
                return View();
            }
            else 
            {
                ViewData["alert"] = "zmiany zakonczyly sie niepowodzeniem";
                return View();    
            }
        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UsunPost(int id)
        {
            
                db_admin.UsunPost(id);
                return RedirectToAction("Index");
          
        }
     



    }
}
