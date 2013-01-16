using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public class MortgageRequirementDto : RequirementDto {

    public MortgageRequirementDto()
    {
      
    }
    public MortgageRequirementDto(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate)
      : base(id, createdDate)
    {
      LoanAmount = loanAmount;
      TermInMonths = termInMonths;
      PurchasePrice = purchasePrice;
      Recommended = recommended;

      return;
    }
    public Decimal LoanAmount { get;  set; }
    public int TermInMonths { get;  set; }
    public Decimal PurchasePrice { get;  set; }
    public bool Recommended { get;  set; }
  }
}
