using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CliftonAgility
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Email Preview",
                url: "Emails/{action}",
                defaults: new { controller = "EmailPreview", action = "Index" });

            // Home
            routes.MapRoute(
                name: "Home Venue",
                url: "find-us",
                defaults: new { controller = "home", action = "ourvenue" });

            routes.MapRoute(
                name: "Home About",
                url: "about-us",
                defaults: new { controller = "home", action = "about" });

            routes.MapRoute(
                name: "Home Thankyou",
                url: "thank-you",
                defaults: new { controller = "home", action = "thankyou" });

            routes.MapRoute(
                name: "Home Contact",
                url: "contact-us",
                defaults: new { controller = "home", action = "contact" });

            // Membership
            routes.MapRoute(
                name: "Membership Form",
                url: "membership-form",
                defaults: new { controller = "membership", action = "index" });

            routes.MapRoute(
                name: "Membership Thankyou",
                url: "membership-form/thank-you",
                defaults: new { controller = "membership", action = "thankyou" });

            // Members Controller
            routes.MapRoute(
                name: "Members Clothing",
                url: "members/club-clothing",
                defaults: new { controller = "members", action = "clubclothing" });

            routes.MapRoute(
                name: "Members Help",
                url: "members/help-advice",
                defaults: new { controller = "members", action = "HelpAdvice" });

            routes.MapRoute(
                name: "Members Downloads",
                url: "members/downloads",
                defaults: new { controller = "members", action = "downloads" });

            // Maps
            routes.MapRoute(
                name: "Madded Locations",
                url: "maps/{locationId}",
                defaults: new { controller = "map", action = "index" });

            // Errors
            routes.MapRoute(
                name: "404 Error",
                url: "404",
                defaults: new { controller = "error", action = "error404" });

            routes.MapRoute(
                name: "500 Error",
                url: "500",
                defaults: new { controller = "error", action = "error500" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
