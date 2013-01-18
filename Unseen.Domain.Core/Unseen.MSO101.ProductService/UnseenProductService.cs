using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;
using Unseen.MSO101.Domain.Core;

namespace Unseen.MSO101.ProductService
{
    public class UnseenProductService :  IMortgageProductService
    {



      List<ProductSummary> IMortgageProductService.ListSuitableProduct(HousePurchaseRequirement requirement) {
        var unseenRequirement = (UnseenMortgageRequirement)requirement;

        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("ShoeSize {0}", unseenRequirement.ShoeSize),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      List<ProductSummary> IMortgageProductService.ListSuitableProduct(BuyToLetRequirement requirement) {
        
        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("ShoeSize {0}", requirement.MonthlyRental),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      List<ProductSummary> IMortgageProductService.ListSuitableProduct(RateSwitchRequirement requirement) {

        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++) {
          var productSummary = new MortgageProductSummary((x % 2) == 0, x, Guid.NewGuid(), string.Format("ShoeSize {0}", requirement.AccountToSwitch),
                                                          string.Format("Description for product {0}", x));
          summaries.Add(productSummary);
        }

        return summaries;
      }

      Product IProductService.GetProductDetails(Guid productId) {
        return new MortgageProduct(false, 3.7M, productId, "Unseen Test Product", "This is just a test product");
      }
    }
}
