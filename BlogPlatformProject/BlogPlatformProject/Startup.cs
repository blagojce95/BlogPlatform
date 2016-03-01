using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogPlatformProject.Startup))]
namespace BlogPlatformProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
