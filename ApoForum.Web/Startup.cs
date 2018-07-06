using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApoForum.Web.Startup))]
namespace ApoForum.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
