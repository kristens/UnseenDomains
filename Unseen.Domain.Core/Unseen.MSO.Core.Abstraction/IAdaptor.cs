using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Core.DTOs;

namespace Unseen.MSO.Core.Abstraction {
  public interface IAdaptor
  {

    SolutionDto AdaptSolution(Solution domainSolution);

    List<SolutionSummaryDto> AdaptionSolutionSummary(List<SolutionSummary> domainSolutionSummary);

    ProductDto AdaptProduct(Product domainProduct);

    Requirement AdaptRequirement(RequirementDto dtoRequirement);

    List<ProductSummaryDto> AdaptProductSummary(List<ProductSummary> domainProductSummary);

    List<CaseSummaryDTO> AdaptCaseSummary(List<CaseSummary> domainCaseSummaries);
  }
}
