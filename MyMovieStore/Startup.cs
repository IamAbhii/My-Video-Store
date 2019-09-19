using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMovieStore.Startup))]
namespace MyMovieStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
