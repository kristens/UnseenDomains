﻿using System;
using System.Collections.Generic;
using Unseen.Domain.Core;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.ApplicationServices.Intermediary
{
    public class MortgageModellingService
    {
      private IIntermediaryAdaptor _IntermediaryAdaptor;
      private IIntermediarySolutionRepository _SolutionRespository;
      private IIntermediaryProductService _intermediaryProductService;

      /// <summary>
      /// Construct, assume unity provides everything
      /// </summary>
      /// <param name="intermediaryAdaptor"></param>
      /// <param name="solutionRespository"></param>
      public MortgageModellingService(IIntermediaryAdaptor intermediaryAdaptor, IIntermediarySolutionRepository solutionRespository, IIntermediaryProductService intermediaryProductService)
      {
        _IntermediaryAdaptor = intermediaryAdaptor;
        _SolutionRespository = solutionRespository;
        _intermediaryProductService = intermediaryProductService;

        return;
      }

      /// <summary>
      /// Return a list of solutions for the case
      /// </summary>
      /// <param name="caseDto"></param>
      /// <returns></returns>
      public virtual List<SolutionSummaryDto> ListSolutionsForCase(IntermediaryCaseDto caseDto)
      {
        var theCase = _IntermediaryAdaptor.AdaptCase(caseDto);

        // convert the DTOs into domain objects
        var solutions = _SolutionRespository.List((IntermediaryCase) theCase);

        var summaries = _IntermediaryAdaptor.AdaptionSolutionSummary(solutions);

        return summaries;
      }

      /// <summary>
      /// Get the complete solution
      /// </summary>
      /// <param name="solutionId"></param>
      /// <param name="intermediaryOwner"></param>
      /// <returns></returns>
      public virtual MortgageSolutionDto GetSolution(Guid solutionId, IntermediaryUserDto intermediaryOwner)
      {
        var owner = _IntermediaryAdaptor.AdaptOwner(intermediaryOwner);

        var solution = _SolutionRespository.Get(solutionId);

        return (MortgageSolutionDto)_IntermediaryAdaptor.AdaptSolution(solution);
      }


      public virtual List<ProductSummaryDto> ListSuitableProduct(MortgageRequirementDto requirement, IntermediaryDetailsDto intermediaryDetailsDto)
      {
        var domainRequirement = _IntermediaryAdaptor.AdaptRequirement(requirement);
        var intermediaryDetails = _IntermediaryAdaptor.AdaptIntermediaryDetails(intermediaryDetailsDto);

        var suitableProducts = _intermediaryProductService.ListProducts(domainRequirement, intermediaryDetails);

        var suitableDtoProducts = _IntermediaryAdaptor.AdaptProductSummary(suitableProducts);

        return suitableDtoProducts;
      }
    }
}
