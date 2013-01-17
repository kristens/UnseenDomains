using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.Domain.Core.Abstractions.Consumer;
using Unseen.Domain.Core.Abstractions.Intermediary;
using Unseen.Domain.Core.Entities;

namespace Unseen.MSO.Core.InfrastructureServices
{
    public class MortgageProductService : ProductService, IIntermediaryMortgageProductService, IConsumerProductService
    {
      List<ProductSummary> IIntermediaryMortgageProductService.ListProducts(Requirement requirement, IntermediaryDetails intermediaryDetails)
      {

        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++)
        {
          var productSummary = new MortgageProductSummary((x%2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      /// <summary>
      /// Call product factory
      /// </summary>
      /// <param name="productId"></param>
      /// <returns></returns>
      public override Product GetProductDetails(Guid productId) {
        return new MortgageProduct(false, 3.7M, productId, "Test Product", "This is just a test product");
      }

      public override List<ProductSummary> ListProducts(Requirement requirement) {
        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("Name {0}", x),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }
    }
}
