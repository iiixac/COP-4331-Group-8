using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageBandage.Startup))]
namespace ManageBandage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
