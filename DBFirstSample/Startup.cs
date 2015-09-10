using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBFirstSample.Startup))]
namespace DBFirstSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
