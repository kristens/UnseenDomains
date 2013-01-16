using System.Collections.Generic;

namespace Unseen.Domain.Core {
  public abstract class Solution {


    protected Solution(List<Product> products, Requirement requirement)
    {
      Products = products;
      Requirement = requirement;

      return;
    }

    public List<Product> Products { get; private set; }

    public Requirement Requirement { get; private set; }
  }
}
