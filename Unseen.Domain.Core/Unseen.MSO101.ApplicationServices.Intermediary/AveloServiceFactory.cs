using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Adaptors;
using Unseen.MSO.ApplicationServices.Intermediary;
using Unseen.MSO.Core.Repositories;
using Unseen.MSO101.Adaptors;

namespace Unseen.MSO101.ApplicationServices.Intermediary {
  
  public static class UnseenServiceFactory {

    public static MortgageModellingService GetModellingService() {
      var adaptor = new UnseenMortgageAdaptor();
      var solutionRepository = new MortgageSolutionRepository();
      var service = new MortgageModellingService(adaptor, solutionRepository);

      return service;
    }
  }
}
