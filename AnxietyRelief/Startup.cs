using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnxietyRelief.Startup))]
namespace AnxietyRelief
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
