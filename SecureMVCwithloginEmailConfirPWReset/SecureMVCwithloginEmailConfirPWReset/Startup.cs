using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureMVCwithloginEmailConfirPWReset.Startup))]
namespace SecureMVCwithloginEmailConfirPWReset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
