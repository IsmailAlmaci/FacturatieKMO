using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_FacturatieMVC.Startup))]
namespace UI_FacturatieMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
