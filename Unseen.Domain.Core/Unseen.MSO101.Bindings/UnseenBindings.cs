using Ninject.Modules;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Consumer;
using Unseen.Domain.Core.Abstractions.Intermediary;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.Repositories;
using Unseen.MSO101.Adaptors;
using Unseen.MSO101.ProductService;

namespace Unseen.MSO101.Bindings
{
    public class UnseenBindings: NinjectModule
    {
      public override void Load() {
        Bind<IConsumerProductService>().To<UnseenProductService>();
        Bind<IAdaptor>().To<ConsumerMortgageAdaptor>();

        Bind<IIntermediaryMortgageProductService>().To<UnseenProductService>();
        Bind<IntermediaryMortgageAdaptor>().To<UnseenMortgageAdaptor>();
        Bind<IIntermediaryAdaptor>().To<UnseenMortgageAdaptor>();

        Bind<IProductService>().To<UnseenProductService>();
        Bind<ICaseRepository>().To<MsoRepository>();
        Bind<IOwnerRepository>().To<MsoRepository>();
        
        return;
      }
    }
}
