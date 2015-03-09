using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularSPA.Startup))]
namespace AngularSPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
