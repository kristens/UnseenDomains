using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;

namespace Unseen.MSO.Core.InfrastructureServices
{
    public class MortgageProductService : IMortgageProductService
    {
      /// <summary>
      /// Call product factory
      /// </summary>
      /// <param name="productId"></param>
      /// <returns></returns>
      public virtual Product GetProductDetails(Guid productId) {
        return new MortgageProduct(false, 3.7M, productId, "Test Product", "This is just a test product");
      }


      public List<ProductSummary> ListSuitableProduct(HousePurchaseRequirement requirement) {
        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                          string.Format("Description for house purchase product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      public List<ProductSummary> ListSuitableProduct(BuyToLetRequirement requirement) {
        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                          string.Format("Description for buy to let product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      public List<ProductSummary> ListSuitableProduct(RateSwitchRequirement requirement) {
        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                          string.Format("Description for rate switch product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }
    }
}
