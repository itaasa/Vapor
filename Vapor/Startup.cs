using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vapor.Startup))]
namespace Vapor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
