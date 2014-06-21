using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quiron.Startup))]
namespace Quiron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
