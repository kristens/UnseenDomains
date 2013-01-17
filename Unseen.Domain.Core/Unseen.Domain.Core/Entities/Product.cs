using System;

namespace Unseen.Domain.Core.Entities {
  public abstract class Product {

    protected Product(Guid id, string name, string description)
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
