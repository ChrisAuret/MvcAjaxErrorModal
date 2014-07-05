using Microsoft.Owin;
using MvcAjaxErrorModal;
using Owin;


[assembly: OwinStartupAttribute(typeof(Startup))]
namespace MvcAjaxErrorModal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
