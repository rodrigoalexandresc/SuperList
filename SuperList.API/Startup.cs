using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SuperList.CrossCutting;
using System.Web.Http;

[assembly: OwinStartup(typeof(SuperList.API.Startup))]

namespace SuperList.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureDependencyInjection();
            ConfigureAuth(app);                                  
        }

        private void ConfigureDependencyInjection()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            DIConfig.Configure(container);

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);


        }
    }
}
