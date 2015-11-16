using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portal3.Startup))]
namespace portal3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
