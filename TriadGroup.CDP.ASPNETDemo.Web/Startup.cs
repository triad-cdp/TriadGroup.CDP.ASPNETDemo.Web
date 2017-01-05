using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TriadGroup.CDP.ASPNETDemo.Web.Startup))]
namespace TriadGroup.CDP.ASPNETDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
