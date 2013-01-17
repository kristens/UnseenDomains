
using Ninject.Modules;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Consumer;
using Unseen.Domain.Core.Abstractions.Intermediary;
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
        Bind<IConsumerProductService>().To<MortgageProductService>();
        Bind<IAdaptor>().To<ConsumerMortgageAdaptor>();


        Bind<IIntermediaryMortgageProductService>().To<MortgageProductService>();
        Bind<IIntermediaryAdaptor>().To<IntermediaryMortgageAdaptor>();

        Bind<ICaseRepository>().To<MsoRepository>();
        Bind<IOwnerRepository>().To<MsoRepository>();
        Bind<IProductService>().To<MortgageProductService>();
        return;
      }
    }
}
