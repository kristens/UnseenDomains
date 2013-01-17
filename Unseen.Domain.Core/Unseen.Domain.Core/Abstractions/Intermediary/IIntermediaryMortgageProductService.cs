using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Entities;

namespace Unseen.Domain.Core.Abstractions.Intermediary {
  public interface IIntermediaryMortgageProductService : IProductService
  {

    List<ProductSummary> ListProducts(Requirement requirement, IntermediaryDetails intermediaryDetails);

  }
}
