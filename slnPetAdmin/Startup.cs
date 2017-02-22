using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(slnPetAdmin.Startup))]
namespace slnPetAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
