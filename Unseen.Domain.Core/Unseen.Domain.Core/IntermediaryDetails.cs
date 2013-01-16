using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.Domain.Core {
  public class IntermediaryDetails {

    public IntermediaryDetails(string mortgageClub)
    {
      MortgageClub = mortgageClub;

      return;
    }

    public string MortgageClub { get; private set; }
  }
}
