using System;
using System.Collections.Generic;

namespace Unseen.Domain.Core.Entities {
  public abstract class  Requirement {


    protected Requirement(Guid id, DateTime createdDate) 
    {
      Id = id;
      CreatedDate = createdDate;

      return;
    }
    public Guid Id { get; private set; }

    public DateTime CreatedDate { get; private set; }

    public abstract List<ProductSummary> ListSuitableProducts();

  }
}
