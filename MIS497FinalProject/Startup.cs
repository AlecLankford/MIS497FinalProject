using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS497FinalProject.Startup))]
namespace MIS497FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
