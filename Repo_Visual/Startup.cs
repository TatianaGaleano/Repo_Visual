using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo_Visual.Startup))]
namespace Repo_Visual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
