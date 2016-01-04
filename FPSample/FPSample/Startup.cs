using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPSample.Startup))]
namespace FPSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
