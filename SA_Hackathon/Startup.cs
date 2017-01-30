using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SA_Hackathon.Startup))]
namespace SA_Hackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
