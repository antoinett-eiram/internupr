using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(internUPR.Startup))]
namespace internUPR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
