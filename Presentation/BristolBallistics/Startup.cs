using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BristolBallistics.Startup))]
namespace BristolBallistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
