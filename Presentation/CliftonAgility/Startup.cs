using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CliftonAgility.Startup))]
namespace CliftonAgility
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
