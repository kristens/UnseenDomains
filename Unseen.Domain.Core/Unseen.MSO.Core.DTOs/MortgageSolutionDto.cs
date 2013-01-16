using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public class MortgageSolutionDto : SolutionDto {

    public MortgageSolutionDto(List<ProductDto> products, MortgageRequirementDto requirement)
      : base(products, requirement)
    {

      return;
    }
  }
}
