using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeadlightApp.Startup))]
namespace HeadlightApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
