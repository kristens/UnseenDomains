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

namespace Unseen.MSO.Bindings
{
    public class DefaultBindings : NinjectModule
    {
      public override void Load()
      {
        Bind<IConsumerSolutionRepository>().To<MortgageSolutionRepository>();
        Bind<IConsumerProductService>().To<MortgageProductService>();
        Bind<IAdaptor>().To<ConsumerMortgageAdaptor>();


        Bind<IIntermediarySolutionRepository>().To<MortgageSolutionRepository>();
        Bind<IIntermediaryProductService>().To<MortgageProductService>();
        Bind<IIntermediaryRepository>().To<IntermediaryRepository>();
        Bind<IIntermediaryAdaptor>().To<IntermediaryMortgageAdaptor>();

        return;
      }
    }
}
