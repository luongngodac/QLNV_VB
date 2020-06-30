using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLNV_VB.Startup))]
namespace QLNV_VB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
