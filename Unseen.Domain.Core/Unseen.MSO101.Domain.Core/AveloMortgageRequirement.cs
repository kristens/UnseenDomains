using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;

namespace Unseen.MSO101.Domain.Core
{
    public class UnseenMortgageRequirement: MortgageRequirement
    {

      public UnseenMortgageRequirement(int shoeSize, Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate):
        base(id, loanAmount, termInMonths,  purchasePrice, recommended, createdDate)
      {
        ShoeSize = shoeSize;

        return;
      }

      public int ShoeSize { get; set; }
    }
}
