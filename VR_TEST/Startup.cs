using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VR_TEST.Startup))]
namespace VR_TEST
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
