using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labtaskSSMS01.Startup))]
namespace labtaskSSMS01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
