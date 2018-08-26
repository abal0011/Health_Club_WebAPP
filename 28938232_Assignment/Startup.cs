using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_28938232_Assignment.Startup))]
namespace _28938232_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
