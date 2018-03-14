using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberProfiling.Startup))]
namespace MemberProfiling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
