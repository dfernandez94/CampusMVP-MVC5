using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Curso_MVC5.Startup))]
namespace Curso_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
