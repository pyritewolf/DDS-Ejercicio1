using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDS_UML_Ejercicio1.Startup))]
namespace DDS_UML_Ejercicio1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
