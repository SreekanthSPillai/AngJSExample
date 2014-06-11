// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Canada Life">
//   Copyright © 2014 Canada Life
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

[assembly: Microsoft.Owin.OwinStartup(typeof(App.AngularJS.Startup))]

namespace App.AngularJS
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //// For more information on how to configure your application, visit:
            //// http://go.microsoft.com/fwlink/?LinkID=316888

            this.ConfigureAuth(app);
        }
    }
}
