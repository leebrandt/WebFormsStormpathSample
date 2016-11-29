using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;

[assembly: OwinStartup(typeof(WebFormsExample.Startup))]

namespace WebFormsExample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseStormpath();
        }
    }
}
