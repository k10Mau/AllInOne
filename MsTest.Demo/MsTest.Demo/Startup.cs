using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MsTest.Demo.Startup))]
namespace MsTest.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
