using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace aspdotnet_webapp_techlink_maintenance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Site", action = "Index", id = UrlParameter.Optional }
            ); 
            routes.MapRoute(
                 name: "PCCC",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Site", action = "PCCC", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                 name: "PCCCScan",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Site", action = "PCCCScan", id = UrlParameter.Optional }
             );
        }
    }
}
