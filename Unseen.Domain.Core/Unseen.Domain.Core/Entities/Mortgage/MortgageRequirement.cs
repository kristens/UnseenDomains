using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities.Mortgage {
  public abstract class MortgageRequirement: Requirement
  {

    protected IMortgageProductService _productService;

    public MortgageRequirement(Guid id, DateTime createdDate, IMortgageProductService productService)
      :this(id ,createdDate) {
     
      _productService = productService;
      return;
    }

    public MortgageRequirement(Guid id,  DateTime createdDate)
      : base(id, createdDate) {
      
      return;
    }


    // Load the requirement from the database, but how do we know whats what?
  }
}
