using System.Collections.Generic;

namespace Unseen.Domain.Core.Entities.Mortgage {
  public class MortgageSolution : Solution {

    public MortgageSolution(List<Product> products, MortgageRequirement requirement): base (products, requirement)
    {

      return;
    }

    /// <summary>
    /// confirm that the solution is valid
    /// </summary>
    /// <returns></returns>
    public override bool IsValid() {
      throw new System.NotImplementedException();
    }
  }
}
