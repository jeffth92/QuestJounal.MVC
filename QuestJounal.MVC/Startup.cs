using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestJounal.MVC.Startup))]
namespace QuestJounal.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
