using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities {
  public class IntermediaryRequirement: MortgageRequirement {

    public IntermediaryRequirement(string mortgageClub, Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate)
      : base(id, loanAmount, termInMonths, purchasePrice, recommended, createdDate)
    {

      MortgageClub = mortgageClub;
      return;
    }

    public IntermediaryRequirement(string mortgageClub, Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate, IProductService productService)
      : base(id, loanAmount, termInMonths, purchasePrice, recommended, createdDate, productService) {
        MortgageClub = mortgageClub;
      return;
    }

    public string MortgageClub { get; set; }
  }
}
