using AnadiendoFuncionalidades.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace AnadiendoFuncionalidades
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var constraintsResolver = new DefaultInlineConstraintResolver();
            constraintsResolver.ConstraintMap.Add("startsWith", typeof(StartsWithConstraint));
            routes.MapMvcAttributeRoutes(constraintsResolver);
            

            routes.MapRoute(
                name: "post",
                url: "view/{code}",
                defaults: new { controller = "Blog", action = "ViewPost" }
            );

            routes.MapRoute(
               name: "archive",
               url: "blog/archive/{year}/{month}",
               defaults: new { controller = "Blog", action = "Archive" }
            );
            
            /*Products*/
            /*routes.MapRoute(
               name: "productsAll",
               url: "products/",
               defaults: new { controller = "Products", action = "index" }
            );

            routes.MapRoute(
               name: "productsAll2",
               url: "products/all",
               defaults: new { controller = "Products", action = "index" }
            );

            routes.MapRoute(
               name: "productsId",
               url: "products/{id}",
               defaults: new { controller = "Products", action = "View" }
            );

            routes.MapRoute(
               name: "productscategory",
               url: "products/category/{category}",
               defaults: new { controller = "Products", action = "ByCategory" }
            );


            /*Friands*/
            /*routes.MapRoute(
               name: "friendsAll",
               url: "friends/",
               defaults: new { controller = "Friends", action = "index" }
            );

            routes.MapRoute(
               name: "friendsView",
               url: "friends/View/{name}",
               defaults: new { controller = "Friends", action = "view" }
            );

            routes.MapRoute(
               name: "friendsEdit",
               url: "friends/Edit/{id}",
               defaults: new { controller = "Friends", action = "edit" },
               constraints: new { id = @"{0-9}+" }     // Regular expression
            );

            */
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
