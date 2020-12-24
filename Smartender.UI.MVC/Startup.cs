using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smartender.UI.MVC.Startup))]
namespace Smartender.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
