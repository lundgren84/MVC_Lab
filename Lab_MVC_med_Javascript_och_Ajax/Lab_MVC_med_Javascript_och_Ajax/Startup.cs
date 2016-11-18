using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_MVC_med_Javascript_och_Ajax.Startup))]
namespace Lab_MVC_med_Javascript_och_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
