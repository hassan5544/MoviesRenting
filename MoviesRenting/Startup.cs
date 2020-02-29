using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRenting.Startup))]
namespace MoviesRenting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
