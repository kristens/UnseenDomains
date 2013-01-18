using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities.Mortgage {
  public class MortgageRequirement: Requirement
  {

    private IProductService _productService;

    public MortgageRequirement(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate, IProductService productService)
      :this(id, loanAmount,termInMonths, purchasePrice, recommended, createdDate) {
     
      _productService = productService;
      return;
    }

    public MortgageRequirement(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate)
      : base(id, createdDate) {
      LoanAmount = loanAmount;
      TermInMonths = termInMonths;
      PurchasePrice = purchasePrice;
      Recommended = recommended;
      
      return;
    }
    public Decimal LoanAmount { get; private set; }
    public int TermInMonths { get; private set; }
    public Decimal PurchasePrice { get; private set; }
    public bool Recommended { get; private set; }

    public override List<ProductSummary> ListSuitableProducts()
    {
      return _productService.ListProducts(this);
    }

    // Load the requirement from the database, but how do we know whats what?
  }
}
