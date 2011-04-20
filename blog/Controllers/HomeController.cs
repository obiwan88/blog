using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Models;
using blog.Controllers;
namespace blog.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        HomeRepository db = new HomeRepository();
        public ActionResult Index()
        {            
            ViewData["lista"] = db.GetPost();
            ViewData["klista"] = db.GetKomentarz();
            return View();
        }
        


        

    }
}
