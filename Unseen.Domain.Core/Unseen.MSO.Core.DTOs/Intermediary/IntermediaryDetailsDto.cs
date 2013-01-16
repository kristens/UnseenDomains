using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs.Intermediary {
  public class IntermediaryDetailsDto {

    public IntermediaryDetailsDto(string mortgageClub)
    {
      MortgageClub = mortgageClub;

      return;
    }

    public string MortgageClub { get; private set; }
  }
}
