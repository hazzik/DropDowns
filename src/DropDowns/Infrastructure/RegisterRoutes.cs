using System.Web.Mvc;
using System.Web.Routing;
using MvcExtensions;

namespace SampleApplication.Infrastructure
{
    public class RegisterRoutes : RegisterRoutesBase
    {
        public RegisterRoutes(RouteCollection routes) : base(routes)
        {
        }

        protected override void Register()
        {
            Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            Routes.MapRoute("Default", "{controller}/{action}/{id}", new {controller = "Movie", action = "Create", id = UrlParameter.Optional});
        }
    }
}
