using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnadiendoFuncionalidades.Startup))]
namespace AnadiendoFuncionalidades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
