using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Core.DTOs;

namespace Unseen.MSO101.Core.DTOs
{
    public class UnseenMortgageRequirementDto: MortgageRequirementDto
    {
      public UnseenMortgageRequirementDto()
      {
        
      }

      public UnseenMortgageRequirementDto(int shoeSize, Guid id, decimal loanAmount, int termInMonths,
                                         decimal purchasePrice, bool recommended, DateTime createdDate)
        : base(id, loanAmount, termInMonths, purchasePrice, recommended, createdDate)
      {

      }

      public int ShoeSize { get; set; }

    }
}
