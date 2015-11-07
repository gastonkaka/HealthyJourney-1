using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyJourney.Web.Startup))]
namespace HealthyJourney.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
