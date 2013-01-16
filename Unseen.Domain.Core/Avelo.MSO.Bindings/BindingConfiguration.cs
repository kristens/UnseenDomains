using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Unseen.MSO.Core.Abstraction.Consumer;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.InfrastructureServices;

namespace Avelo.MSO.Bindings
{
    public class BindingConfiguration: NinjectModule
    {
      public override void Load() {
        Bind<IIntermediaryProductService>().To<MortgageProductService>();
        Bind<IConsumerProductService>().To<MortgageProductService>();
      }
    }
}
