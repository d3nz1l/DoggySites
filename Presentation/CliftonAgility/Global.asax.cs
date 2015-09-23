// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   
// </copyright>
// <summary>
//   The mvc application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility
{
    using System.Globalization;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    /// <summary>
    /// The mvc application.
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void Application_BeginRequest()
        {
            var context = HttpContext.Current;

            var currentHost = context.Request.Url.Host.ToUpperInvariant();

            if (currentHost.StartsWith("WWW"))
            {
                return;
            }

            var newHost = string.Format(CultureInfo.InvariantCulture, "{3}://www.{0}{1}{2}", context.Request.Url.Authority, context.Request.Url.AbsolutePath, context.Request.Url.Query, context.Request.Url.Scheme);

            context.Response.RedirectPermanent(newHost, true);
        }
    }
}
