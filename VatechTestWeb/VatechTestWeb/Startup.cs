using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VatechTestWeb.Startup))]
namespace VatechTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
