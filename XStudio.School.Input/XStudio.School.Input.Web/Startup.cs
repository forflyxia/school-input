using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XStudio.School.Input.Web.Startup))]
namespace XStudio.School.Input.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            ConfigureAuth(app);
        }
    }
}
