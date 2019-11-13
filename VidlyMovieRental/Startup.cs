using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMovieRental.Startup))]
namespace VidlyMovieRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
