using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSSC.Startup))]
namespace PSSC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
