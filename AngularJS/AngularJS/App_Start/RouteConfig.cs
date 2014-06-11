// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Canada Life">
//   Copyright © 2014 Canada Life
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS
{
    using System.Web.Routing;

    using App.AngularJS.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
