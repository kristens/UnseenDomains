using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities.Mortgage
{
  public class BuyToLetRequirement : MortgageRequirement
  {
    public BuyToLetRequirement(Guid id, decimal monthlyRental, DateTime createdDate, IMortgageProductService productService)
      : base(id, createdDate, productService)
    {

      MonthlyRental = monthlyRental;
      return;
    }

    public BuyToLetRequirement(Guid id, decimal monthlyRental, DateTime createdDate)
      : this(id, monthlyRental, createdDate, null)
    {

      return;
    }

    public Decimal MonthlyRental { get; private set; }

    public override List<ProductSummary> ListSuitableProducts() {
      return _productService.ListSuitableProduct(this);
    }
  }
}
