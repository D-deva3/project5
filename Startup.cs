using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(StudentManagement.StartupOwin))]

namespace StudentManagement
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
