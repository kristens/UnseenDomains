
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Adaptors;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO101.Core.DTOs;
using Unseen.MSO101.Domain.Core;

namespace Unseen.MSO101.Adaptors
{
  public class UnseenMortgageAdaptor : IntermediaryMortgageAdaptor, IAdaptor
  {
    private readonly IMortgageProductService _productService;
    public UnseenMortgageAdaptor(IMortgageProductService productService)
      : base(productService)
    {
      _productService = productService;
      return;
    }


    Requirement IAdaptor.AdaptRequirement(RequirementDto dtoRequirement) {
      var mortgageRequirementDto = (UnseenMortgageRequirementDto)dtoRequirement;

      var requirement = new UnseenMortgageRequirement(mortgageRequirementDto.ShoeSize, mortgageRequirementDto.Id, mortgageRequirementDto.LoanAmount, mortgageRequirementDto.TermInMonths,
                                                      mortgageRequirementDto.PurchasePrice, mortgageRequirementDto.Recommended,
                                                      mortgageRequirementDto.CreatedDate, _productService);

      return requirement;
    }
  }
}
