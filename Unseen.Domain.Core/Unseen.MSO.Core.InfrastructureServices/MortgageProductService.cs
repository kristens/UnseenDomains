using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.Abstraction.Consumer;
using Unseen.MSO.Core.Abstraction.Intermediary;

namespace Unseen.MSO.Core.InfrastructureServices
{
    public class MortgageProductService : IIntermediaryProductService, IConsumerProductService
    {
      List<ProductSummary> IIntermediaryProductService.ListProducts(Requirement requirement, IntermediaryDetails intermediaryDetails)
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
      Product IIntermediaryProductService.GetProduct(Guid productId) {
        return new MortgageProduct(false, 3.7M, productId, "Test Product", "This is just a test product");
      }

      
    }
}
