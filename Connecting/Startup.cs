using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Connecting.Startup))]
namespace Connecting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); 

            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            hubConfiguration.EnableJavaScriptProxies = true;

            app.MapSignalR("/signalr", hubConfiguration);
        }
    }
} 