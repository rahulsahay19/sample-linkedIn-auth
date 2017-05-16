using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleLinkedIn.Startup))]
namespace SampleLinkedIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
