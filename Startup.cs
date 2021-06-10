using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingGitHubGCD0803.Startup))]
namespace TestingGitHubGCD0803
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
