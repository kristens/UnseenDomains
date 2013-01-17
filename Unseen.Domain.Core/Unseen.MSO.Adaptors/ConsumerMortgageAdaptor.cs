using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Core.Abstraction;

namespace Unseen.MSO.Adaptors {
  public class ConsumerMortgageAdaptor: IAdaptor {
    Core.DTOs.SolutionDto IAdaptor.AdaptSolution(Solution domainSolution) {
      throw new NotImplementedException();
    }

    List<Core.DTOs.SolutionSummaryDto> IAdaptor.AdaptionSolutionSummary(List<SolutionSummary> domainSolutionSummary) {
      throw new NotImplementedException();
    }



    Core.DTOs.ProductDto IAdaptor.AdaptProduct(Product domainProduct) {
      throw new NotImplementedException();
    }



    Core.DTOs.RequirementDto IAdaptor.AdaptRequirement(Requirement domainRequirement) {
      throw new NotImplementedException();
    }

    Requirement IAdaptor.AdaptRequirement(Core.DTOs.RequirementDto dtoRequirement) {
      throw new NotImplementedException();
    }

    List<Core.DTOs.ProductSummaryDto> IAdaptor.AdaptProductSummary(List<ProductSummary> domainProductSummary) {
      throw new NotImplementedException();
    }


    List<Core.DTOs.CaseSummaryDTO> IAdaptor.AdaptCaseSummary(List<CaseSummary> domainCaseSummaries) {
      throw new NotImplementedException();
    }
  }
}
