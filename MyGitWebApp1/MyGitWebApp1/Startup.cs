using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitWebApp1.Startup))]
namespace MyGitWebApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
