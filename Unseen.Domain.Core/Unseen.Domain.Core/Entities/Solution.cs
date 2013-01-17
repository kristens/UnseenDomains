using System.Collections.Generic;

namespace Unseen.Domain.Core.Entities {
  public abstract class Solution {


    protected Solution(List<Product> products, Requirement requirement)
    {
      Products = products;
      Requirement = requirement;

      return;
    }

    /// <summary>
    /// The products that belong to this solution
    /// </summary>
    public List<Product> Products { get; private set; }

    /// <summary>
    /// The requirements for this solution
    /// </summary>
    public Requirement Requirement { get; private set; }

    /// <summary>
    /// Is this solution valid?
    /// </summary>
    /// <returns></returns>
    public abstract bool IsValid();
  }
}
