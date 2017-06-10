using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(menume.Startup))]
namespace menume
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
