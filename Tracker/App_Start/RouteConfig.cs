using System.Web.Mvc;
using System.Web.Routing;

namespace Tracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "resume",
               url: "resume/{*catch-all}",
               defaults: new
               {
                   controller = "Home",
                   action = "Resume"
               });

            routes.MapRoute(
                name: "skills",
                url: "skills/{*catch-all}",
                defaults: new
                {
                    controller = "Home",
                    action = "Skills"
                });

            routes.MapMvcAttributeRoutes();
        }
    }
}
