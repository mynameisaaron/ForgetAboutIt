using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForgetAboutIt.Startup))]
namespace ForgetAboutIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
