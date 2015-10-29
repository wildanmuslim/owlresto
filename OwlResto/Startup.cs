using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OwlResto.Startup))]
namespace OwlResto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
