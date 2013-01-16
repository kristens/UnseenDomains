using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avelo.MSO.Bindings;
using Ninject;
using Unseen.MSO.Core.Abstraction.Consumer;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.InfrastructureServices;

namespace Unseen.MSO.Domain.Factories
{
    public static class InfrastructureFactory
    {
      private static IKernel _kernel = new StandardKernel(new BindingConfiguration());


      public static IIntermediaryProductService CreateIntermediaryProductService()
      {
        return _kernel.Get<MortgageProductService>();
      }
    }
}
