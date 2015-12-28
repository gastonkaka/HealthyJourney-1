using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyJourney.Angular.Startup))]
namespace HealthyJourney.Angular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
