using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public abstract class ProductDto {

    protected ProductDto(Guid id, string name, string description)
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
