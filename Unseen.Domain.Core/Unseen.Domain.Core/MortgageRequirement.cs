using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.Domain.Core {
  public class MortgageRequirement: Requirement {

    public MortgageRequirement(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate)
      : base(id, createdDate)
    {
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
  }
}
