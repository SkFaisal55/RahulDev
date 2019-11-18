using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RahulDev.Startup))]
namespace RahulDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
