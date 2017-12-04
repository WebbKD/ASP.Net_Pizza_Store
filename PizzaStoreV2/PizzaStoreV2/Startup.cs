using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaStoreV2.Startup))]
namespace PizzaStoreV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
