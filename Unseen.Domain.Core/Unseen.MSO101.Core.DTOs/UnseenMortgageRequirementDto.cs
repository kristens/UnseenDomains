using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO101.Core.DTOs
{
    public class UnseenMortgageRequirementDto: IntermediaryRequirementDto
    {
      public UnseenMortgageRequirementDto()
      {
        
      }

      public UnseenMortgageRequirementDto(int shoeSize, string mortgageClub, Guid id, decimal loanAmount, int termInMonths,
                                         decimal purchasePrice, bool recommended, DateTime createdDate)
        : base(mortgageClub, id, loanAmount, termInMonths, purchasePrice, recommended, createdDate)
      {
        ShoeSize = shoeSize;
        return;
      }

      public int ShoeSize { get; set; }

    }
}
