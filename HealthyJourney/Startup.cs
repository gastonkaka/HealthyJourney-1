using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyJourney.Startup))]
namespace HealthyJourney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
