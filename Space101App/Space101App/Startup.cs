using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Space101App.Startup))]
namespace Space101App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
