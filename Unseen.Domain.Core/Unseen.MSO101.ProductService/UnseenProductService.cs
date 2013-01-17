using System;
using System.Collections.Generic;

using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Core.InfrastructureServices;
using Unseen.MSO101.Domain.Core;

namespace Unseen.MSO101.ProductService
{
    public class UnseenProductService : MortgageProductService
    {

      public override  List<ProductSummary> ListProducts(Requirement requirement) {
        var unseenRequirement = (UnseenMortgageRequirement)requirement;

        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("ShoeSize {0}", unseenRequirement.ShoeSize),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }
    }
}
