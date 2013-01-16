using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public abstract class SolutionDto {

    protected SolutionDto(List<ProductDto> products, RequirementDto requirement)
    {
      Products = products;
      Requirement = requirement;

      return;
    }

    public List<ProductDto> Products { get; private set; }

    public RequirementDto Requirement { get; private set; }
  }
}
