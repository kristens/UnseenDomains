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

        /// <summary>
    /// BTL entry point
    /// </summary>
    /// <param name="monthlyRental"></param>
    /// <param name="id"></param>

    public MortgageRequirementDto(Decimal monthlyRental, Guid id, DateTime createdDate)
      : base(id, createdDate)
    {
      MonthlyRental = monthlyRental;

      return;
    }

    /// <summary>
    /// Rate Switch entry point
    /// </summary>
    /// <param name="accountToSwitch"></param>
    /// <param name="id"></param>

    public MortgageRequirementDto(string accountToSwitch, Guid id, DateTime createdDate)
      : base(id, createdDate) {
      AccountToSwitch = accountToSwitch;

      return;
    }

    public Decimal LoanAmount { get;  set; }
    public int TermInMonths { get;  set; }
    public Decimal PurchasePrice { get;  set; }
    public bool Recommended { get;  set; }

  
    public decimal MonthlyRental { get; private set; }
    public string AccountToSwitch { get; private set; }

  }
}
