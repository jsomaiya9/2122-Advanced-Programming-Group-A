using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationTechnology.Startup))]
namespace InformationTechnology
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
