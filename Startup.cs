using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_trang.Startup))]
namespace lab3_trang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
