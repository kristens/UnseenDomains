
using Ninject.Modules;
using Unseen.Domain.Core.Abstractions;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.InfrastructureServices;
using Unseen.MSO.Core.Repositories;

namespace Unseen.MSO.Bindings
{
    public class DefaultBindings : NinjectModule
    {
      public override void Load()
      {
       
        Bind<IAdaptor>().To<IntermediaryMortgageAdaptor>();

        Bind<IProductService>().To<IntermediaryMortgageProductService>();
        Bind<ICaseRepository>().To<MsoRepository>();
        Bind<IOwnerRepository>().To<MsoRepository>();
        return;
      }
    }
}
