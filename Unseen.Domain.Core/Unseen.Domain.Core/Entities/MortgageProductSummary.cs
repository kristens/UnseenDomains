using System;

namespace Unseen.Domain.Core.Entities {
  public class MortgageProductSummary : ProductSummary {

    public MortgageProductSummary(bool ercApply, decimal interestRate, Guid id, string name, string description)
      : base(id, name, description)
    {
      ErcApply = ercApply;
      InterestRate = interestRate;
      return;
    }
    public bool ErcApply { get; private set; }
    public decimal InterestRate { get; private set; }
  }
}
