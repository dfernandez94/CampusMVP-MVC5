using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormularioEdicion.Startup))]
namespace FormularioEdicion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
