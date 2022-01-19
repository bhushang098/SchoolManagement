using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(SchoolManagement.Startup))]
namespace SchoolManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        public void createuser()
        {
            Console.WriteLine("TESt for Github");
        }
    }
}
