using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSProject.Startup))]
namespace MSProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
