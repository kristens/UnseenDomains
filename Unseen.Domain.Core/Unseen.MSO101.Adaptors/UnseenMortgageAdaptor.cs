using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO101.Core.DTOs;
using Unseen.MSO101.Domain.Core;

namespace Unseen.MSO101.Adaptors
{
  public class UnseenMortgageAdaptor : IntermediaryMortgageAdaptor, IIntermediaryAdaptor
  {
    RequirementDto IAdaptor.AdaptRequirement(Requirement domainRequirement) {

      var mortgageRequirement = (UnseenMortgageRequirement)domainRequirement;

      var dtoRequirement = new UnseenMortgageRequirementDto(mortgageRequirement.ShoeSize, mortgageRequirement.Id, mortgageRequirement.LoanAmount, mortgageRequirement.TermInMonths,
                                                      mortgageRequirement.PurchasePrice, mortgageRequirement.Recommended,
                                                      mortgageRequirement.CreatedDate);

      return dtoRequirement;
    }

    Requirement IAdaptor.AdaptRequirement(RequirementDto dtoRequirement) {
      var mortgageRequirementDto = (UnseenMortgageRequirementDto)dtoRequirement;

      var requirement = new UnseenMortgageRequirement(mortgageRequirementDto.ShoeSize, mortgageRequirementDto.Id, mortgageRequirementDto.LoanAmount, mortgageRequirementDto.TermInMonths,
                                                      mortgageRequirementDto.PurchasePrice, mortgageRequirementDto.Recommended,
                                                      mortgageRequirementDto.CreatedDate);

      return requirement;
    }
  }
}
