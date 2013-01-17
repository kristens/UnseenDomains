using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Repositories;

namespace Unseen.MSO.ApplicationServices.Intermediary {
  public static class IntermediaryFactory
  {

    public static MortgageModellingService GetModellingService(NinjectModule bindings)
    {
      IKernel kernel = new StandardKernel(bindings);

      return kernel.Get < MortgageModellingService>();
    }
  }
}
