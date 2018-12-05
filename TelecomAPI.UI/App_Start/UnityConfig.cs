using System.Web.Http;
using Unity;
using Unity.WebApi;
using TelecomAPI.Services;

namespace TelecomAPI.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IPhoneApi, PhoneApi>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}