using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.Domain.Core {
  public abstract class ProductSummary {
    protected ProductSummary(Guid id, string name, string description)
    {
      Id = id;
      Name = name;
      Description = description;

      return;
    }
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }
  }
}
