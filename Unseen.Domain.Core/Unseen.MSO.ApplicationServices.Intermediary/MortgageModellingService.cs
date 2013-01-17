using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.ApplicationServices.Intermediary
{
    public class MortgageModellingService
    {
      private readonly IAdaptor _IntermediaryAdaptor;
      private readonly IOwnerRepository _ownerRepository; 

      /// <summary>
      /// construct
      /// </summary>
      /// <param name="intermediaryAdaptor"></param>
      /// <param name="intermediaryProductService"></param>
      /// <param name="ownerRepository"></param>
      public MortgageModellingService(IAdaptor intermediaryAdaptor, IOwnerRepository ownerRepository)
      {
        _IntermediaryAdaptor = intermediaryAdaptor;
        _ownerRepository = ownerRepository;
        return;
      }

      /// <summary>
      /// Return a list of solutions for the case
      /// </summary>
      /// <param name="caseDto"></param>
      /// <returns></returns>
      public virtual List<SolutionSummaryDto> ListSolutionsForCase(CaseDto caseDto)
      {
        // get the user
        var owner = _ownerRepository.GetOwner(caseDto.Owner.Id);

        var solutions = owner.GetCase(caseDto.Id).ListSolutions();

        // convert the DTOs into domain objects
        var summaries = _IntermediaryAdaptor.AdaptionSolutionSummary(solutions);

        return summaries;
      }

      /// <summary>
      /// Get the requested solution for this case
      /// </summary>
      /// <param name="solutionId"></param>
      /// <param name="caseDto"></param>
      /// <returns></returns>
      public virtual MortgageSolutionDto GetSolution(Guid solutionId, CaseDto caseDto)
      {
        var owner = _ownerRepository.GetOwner(caseDto.Owner.Id);

        var targetCase = owner.GetCase(caseDto.Id);

        var solution = targetCase.GetSolution(solutionId);

        return (MortgageSolutionDto) _IntermediaryAdaptor.AdaptSolution(solution);
      }

      /// <summary>
      /// List the suitable products for this requirement
      /// </summary>
      /// <param name="requirement"></param>
      /// <param name="intermediaryDetailsDto"></param>
      /// <returns></returns>
      public virtual List<ProductSummaryDto> ListSuitableProduct(MortgageRequirementDto requirement)
      {
        var domainRequirement = _IntermediaryAdaptor.AdaptRequirement(requirement);
        
        var suitableProducts = domainRequirement.ListSuitableProducts();

        var suitableDtoProducts = _IntermediaryAdaptor.AdaptProductSummary(suitableProducts);

        return suitableDtoProducts;
      }
    }
}
