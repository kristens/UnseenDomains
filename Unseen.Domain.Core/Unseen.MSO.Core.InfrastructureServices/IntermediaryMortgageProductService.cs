using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;

namespace Unseen.MSO.Core.InfrastructureServices {

  /// <summary>
  /// Intermediary flavour of the product service
  /// </summary>
  public class IntermediaryMortgageProductService: MortgageProductService {

    /// <summary>
    /// Retrieve the products based on the intermediary details added
    /// </summary>
    /// <param name="requirement"></param>
    /// <returns></returns>
    public override List<ProductSummary> ListProducts(Requirement requirement) {
      var summaries = new List<ProductSummary>();

      var intermediaryRequirement = (MortgageRequirement) requirement;

      for (int x = 0; x < 10; x++) {
        var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                        string.Format("Description for product {0} for club {1}", x, intermediaryRequirement.PurchasePrice));
        summaries.Add(productSummary);
      }

      return summaries;
    }
  }
}
