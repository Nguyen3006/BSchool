using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigShools.Startup))]
namespace BigShools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
