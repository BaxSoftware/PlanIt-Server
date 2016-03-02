using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PlanIt_Server.Startup))]

namespace PlanIt_Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}