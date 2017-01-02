using System.Web.Http;
using System.Web.Mvc;
using Ninject;
using Pubwebkit.Promo.Data;
using Pubwebkit.Promo.Data.Contracts;
using Pubwebkit.Promo.Data.Helpers;

namespace Pubwebkit.Promo.Web
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

            // These registrations are "per instance request".
            // See http://blog.bobcravens.com/2010/03/ninject-life-cycle-management-or-scoping/

            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>().InSingletonScope();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<IPubwebkitUow>().To<PubwebkitUow>();

            var dependencyResolver = new NinjectDependencyResolver(kernel);
            config.DependencyResolver = dependencyResolver;
            DependencyResolver.SetResolver(dependencyResolver);
        } 
    }
}