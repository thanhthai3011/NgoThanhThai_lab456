using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab456_NgoThanhThai.Startup))]
namespace Lab456_NgoThanhThai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
