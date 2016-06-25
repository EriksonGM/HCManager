using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCManager.Startup))]
namespace HCManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
