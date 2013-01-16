using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Core.Abstraction.Intermediary;

namespace Unseen.MSO.Core.InfrastructureServices {
  public static class InfrastructureServiceFactory {

    /// <summary>
    /// create a product service
    /// </summary>
    /// <returns></returns>
    public static IIntermediaryProductService CreateIntermediaryProductService()
    {
      return new MortgageProductService();
    }
  }
}
