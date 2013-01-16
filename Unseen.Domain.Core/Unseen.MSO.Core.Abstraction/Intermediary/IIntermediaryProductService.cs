using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;

namespace Unseen.MSO.Core.Abstraction.Intermediary {
  public interface IIntermediaryProductService
  {

    List<ProductSummary> ListProducts(Requirement requirement, IntermediaryDetails intermediaryDetails);

    Product GetProduct(Guid productId);
  }
}
