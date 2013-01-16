using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.Domain.Core {
  public class MortgageProduct : Product {

    public MortgageProduct(bool ercApply, decimal interestRate, Guid id, string name, string description): base(id, name, description)
    {
      ErcApply = ercApply;
      InterestRate = interestRate;
      return;
    }
    public bool ErcApply { get; private set; }
    public decimal InterestRate { get; private set; }
    
  }
}
