using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRABALHO.Startup))]
namespace TRABALHO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
