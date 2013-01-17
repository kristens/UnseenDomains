﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Consumer;
using Unseen.Domain.Core.Abstractions.Intermediary;
using Unseen.Domain.Core.Entities;
using Unseen.MSO101.Domain.Core;

namespace Unseen.MSO101.ProductService
{
    public class UnseenProductService : IIntermediaryMortgageProductService, IConsumerProductService
    {
      List<ProductSummary> IIntermediaryMortgageProductService.ListProducts(Requirement requirement, IntermediaryDetails intermediaryDetails)
      {
        var unseenRequirement = (UnseenMortgageRequirement) requirement;

        var summaries = new List<ProductSummary>();

        for (int x = 0; x < 10; x++)
        {
          var productSummary = new MortgageProductSummary((x%2) == 0, x, Guid.NewGuid(), string.Format("ShoeSize {0}", unseenRequirement.ShoeSize),
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
      Product IProductService.GetProductDetails(Guid productId) {
        return new MortgageProduct(false, 3.7M, productId, "Test Product", "This is just a test product");
      }

      List<ProductSummary> IProductService.ListProducts(Requirement requirement) {
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