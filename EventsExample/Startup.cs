using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventsExample.Startup))]
namespace EventsExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
