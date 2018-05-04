using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecDiegoSouzaASP.Startup))]
namespace RecDiegoSouzaASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
