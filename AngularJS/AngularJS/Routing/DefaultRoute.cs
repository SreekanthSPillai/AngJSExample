// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRoute.cs" company="Canada Life">
//   Copyright © 2014 Canada Life
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS.Routing
{
    using System.Web.Routing;

    public class DefaultRoute : Route
    {
        public DefaultRoute()
            : base("{*path}", new DefaultRouteHandler())
        {
            this.RouteExistingFiles = false;
        }
    }
}
