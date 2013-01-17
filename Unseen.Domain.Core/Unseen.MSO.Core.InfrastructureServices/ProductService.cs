using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;

namespace Unseen.MSO.Core.InfrastructureServices {
  public abstract class ProductService : IProductService
  {
    public abstract Product GetProductDetails(Guid productId);

    public abstract List<ProductSummary> ListProducts(Requirement requirement);
  }
}
