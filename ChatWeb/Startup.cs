using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatWeb.Startup))]
namespace ChatWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
           // ConfigureAuth(app);
        }
    }
}
