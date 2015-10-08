using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ebuy.Web.Startup))]
namespace Ebuy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
