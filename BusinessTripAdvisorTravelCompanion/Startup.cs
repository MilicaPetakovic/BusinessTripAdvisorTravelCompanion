using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessTripAdvisorTravelCompanion.Startup))]
namespace BusinessTripAdvisorTravelCompanion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
