using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities.Mortgage {
  public class RateSwitchRequirement: MortgageRequirement {
    public RateSwitchRequirement(Guid id, string accountToSwitch, DateTime createdDate, IMortgageProductService productService)
      : base(id, createdDate, productService)
    {

      AccountToSwitch = accountToSwitch;
      return;
    }

    public RateSwitchRequirement(Guid id, string accountToSwitch, DateTime createdDate)
      : this(id, accountToSwitch, createdDate, null)
    {

      return;
    }

    public string AccountToSwitch { get; private set; }

    public override List<ProductSummary> ListSuitableProducts() {
      return _productService.ListSuitableProduct(this);
    }
  }
}
