using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.DTOs;

namespace Unseen.MSO.Core.Abstraction {
  public interface IAdaptor
  {

    SolutionDto AdaptSolution(Solution domainSolution);

    Solution AdaptSolution(SolutionDto dtoSolution);

    aCase AdaptCase(CaseDto caseDto);

    CaseDto AdaptCase(aCase domainCase);

    List<SolutionSummaryDto> AdaptionSolutionSummary(List<SolutionSummary> domainSolutionSummary);

    UserDto AdaptOwner(User domainUser);

    User AdaptOwner(UserDto ownerDto);

    ProductDto AdaptProduct(Product domainProduct);

    Product AdaptProduct(ProductDto dtoProduct);

    RequirementDto AdaptRequirement(Requirement domainRequirement);

    Requirement AdaptRequirement(RequirementDto dtoRequirement);

    List<ProductSummaryDto> AdaptProductSummary(List<ProductSummary> domainProductSummary);
  }
}
