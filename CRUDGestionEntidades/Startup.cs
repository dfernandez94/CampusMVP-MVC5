using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDGestionEntidades.Startup))]
namespace CRUDGestionEntidades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
