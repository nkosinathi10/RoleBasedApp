using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBasedApp.Startup))]
namespace RoleBasedApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
