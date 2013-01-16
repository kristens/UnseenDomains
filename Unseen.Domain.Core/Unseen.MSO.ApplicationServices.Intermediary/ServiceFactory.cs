using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.Repositories;

namespace Unseen.MSO.ApplicationServices.Intermediary {
  public static class ServiceFactory {
    static ServiceFactory ()
    {

    }

    public static MortgageModellingService GetModellingService()
    {
      
      var adaptor = new IntermediaryMortgageAdaptor();
      var solutionRepository = new MortgageSolutionRepository();
      var service = new MortgageModellingService(adaptor, solutionRepository);

      return service;
    }
  }
}
