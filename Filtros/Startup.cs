using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filtros.Startup))]
namespace Filtros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
