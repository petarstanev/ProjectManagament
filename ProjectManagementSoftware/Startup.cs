using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectManagementSoftware.Startup))]
namespace ProjectManagementSoftware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
