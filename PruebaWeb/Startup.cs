using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaWeb.Startup))]
namespace PruebaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
