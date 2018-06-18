using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTest_Rafat.Startup))]
namespace MVCTest_Rafat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
