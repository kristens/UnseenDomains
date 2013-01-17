using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.MSO.Core.Abstraction;

namespace Unseen.MSO.Adaptors {
  public class ConsumerMortgageAdaptor: IAdaptor {
    Core.DTOs.SolutionDto IAdaptor.AdaptSolution(Domain.Core.Solution domainSolution) {
      throw new NotImplementedException();
    }

    Domain.Core.Solution IAdaptor.AdaptSolution(Core.DTOs.SolutionDto dtoSolution) {
      throw new NotImplementedException();
    }

    Domain.Core.aCase IAdaptor.AdaptCase(Core.DTOs.CaseDto caseDto) {
      throw new NotImplementedException();
    }

    Core.DTOs.CaseDto IAdaptor.AdaptCase(Domain.Core.aCase domainCase) {
      throw new NotImplementedException();
    }

    List<Core.DTOs.SolutionSummaryDto> IAdaptor.AdaptionSolutionSummary(List<Domain.Core.SolutionSummary> domainSolutionSummary) {
      throw new NotImplementedException();
    }

    Core.DTOs.UserDto IAdaptor.AdaptOwner(Domain.Core.User domainUser) {
      throw new NotImplementedException();
    }

    Domain.Core.User IAdaptor.AdaptOwner(Core.DTOs.UserDto ownerDto) {
      throw new NotImplementedException();
    }

    Core.DTOs.ProductDto IAdaptor.AdaptProduct(Domain.Core.Product domainProduct) {
      throw new NotImplementedException();
    }

    Domain.Core.Product IAdaptor.AdaptProduct(Core.DTOs.ProductDto dtoProduct) {
      throw new NotImplementedException();
    }

    Core.DTOs.RequirementDto IAdaptor.AdaptRequirement(Domain.Core.Requirement domainRequirement) {
      throw new NotImplementedException();
    }

    Domain.Core.Requirement IAdaptor.AdaptRequirement(Core.DTOs.RequirementDto dtoRequirement) {
      throw new NotImplementedException();
    }

    List<Core.DTOs.ProductSummaryDto> IAdaptor.AdaptProductSummary(List<Domain.Core.ProductSummary> domainProductSummary) {
      throw new NotImplementedException();
    }
  }
}
