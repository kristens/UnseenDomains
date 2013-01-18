using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;

namespace Unseen.Domain.Core.Abstractions {
  public interface IMortgageProductService : IProductService
  {

    List<ProductSummary> ListSuitableProduct(HousePurchaseRequirement requirement);

    List<ProductSummary> ListSuitableProduct(BuyToLetRequirement requirement);

    List<ProductSummary> ListSuitableProduct(RateSwitchRequirement requirement);
  }
}
