using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs.Intermediary {
  public class IntermediaryRequirementDto: MortgageRequirementDto {

    public IntermediaryRequirementDto()
    {
      
    }

    public IntermediaryRequirementDto(string mortgageClub, Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice,
                                      bool recommended, DateTime createdDate)
      : base(id, loanAmount, termInMonths, purchasePrice, recommended, createdDate)
    {
      MortgageClub = mortgageClub;

      return;
    }

    public string MortgageClub { get; set; }
  }
}
