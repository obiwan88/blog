using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace blog
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
              "data", // Route name
              "{controller}/{action}/{year}/{month}/{day}", // URL with parameters
              new { controller = "Gosc", action = "data" }, // Parameter defaults
              new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
              );

            routes.MapRoute(
           "tytul", // Route name
           "Gosc/tytul/{tytul}", // URL with parameters
           new { controller = "Gosc", action = "tytul", tytul = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
               "Default", // Route name
               "{controller}/{action}/{id}", // URL with parameters
               new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
           );
         



           

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}