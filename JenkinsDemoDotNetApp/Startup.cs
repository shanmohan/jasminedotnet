using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsDemoDotNetApp.Startup))]
namespace JenkinsDemoDotNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
