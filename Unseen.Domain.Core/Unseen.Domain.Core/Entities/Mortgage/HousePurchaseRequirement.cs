using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities.Mortgage {
  public class HousePurchaseRequirement : MortgageRequirement
  {
    public HousePurchaseRequirement(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice,
                                    bool recommended, DateTime createdDate, IMortgageProductService productService): base(id, createdDate, productService)
    {
      LoanAmount = loanAmount;
      TermInMonths = termInMonths;
      PurchasePrice = purchasePrice;
      Recommended = recommended;

      return;
    }

    public HousePurchaseRequirement(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice,
                                    bool recommended, DateTime createdDate)
      : this(id, loanAmount, termInMonths, purchasePrice, recommended, createdDate, null)
    {

      return;
    }

    public Decimal LoanAmount { get; private set; }
    public int TermInMonths { get; private set; }
    public Decimal PurchasePrice { get; private set; }
    public bool Recommended { get; private set; }


    public override List<ProductSummary> ListSuitableProducts() {
      return _productService.ListSuitableProduct(this);
    }

  }
}
