using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(udemdy1.Startup))]
namespace udemdy1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
