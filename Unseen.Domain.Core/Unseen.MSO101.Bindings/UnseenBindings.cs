using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.Abstraction.Consumer;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.InfrastructureServices;
using Unseen.MSO.Core.Repositories;
using Unseen.MSO101.Adaptors;
using Unseen.MSO101.Core.DTOs;
using Unseen.MSO101.ProductService;

namespace Unseen.MSO101.Bindings
{
    public class UnseenBindings: NinjectModule
    {
      public override void Load() {
        Bind<IConsumerSolutionRepository>().To<MortgageSolutionRepository>();
        Bind<IConsumerProductService>().To<MortgageProductService>();
        Bind<IAdaptor>().To<ConsumerMortgageAdaptor>();


        Bind<IIntermediarySolutionRepository>().To<MortgageSolutionRepository>();
        Bind<IIntermediaryProductService>().To<UnseenProductService>();
        Bind<IIntermediaryRepository>().To<IntermediaryRepository>();
        Bind<IntermediaryMortgageAdaptor>().To<UnseenMortgageAdaptor>();
        Bind<IIntermediaryAdaptor>().To<UnseenMortgageAdaptor>();

        return;
      }
    }
}
