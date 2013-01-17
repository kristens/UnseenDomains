﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Consumer;
using Unseen.Domain.Core.Abstractions.Intermediary;
using Unseen.Domain.Core.Entities;

namespace Unseen.MSO.Core.Repositories {

  /// <summary>
  /// Sits over our database and returns the party information that relates to the owner of this case
  /// </summary>
  public class MsoRepository : IOwnerRepository, ICaseRepository 
  {
    private IIntermediaryMortgageProductService _IntermediaryProductService;
    private IConsumerProductService _ConsumerProductService;

    public MsoRepository(IIntermediaryMortgageProductService intermediaryProductService, IConsumerProductService consumerProductService)
    {
      _IntermediaryProductService = intermediaryProductService;
      _ConsumerProductService = consumerProductService;

      return;
    }

    Owner IOwnerRepository.GetOwner(Guid ownerId) {

      // the Owner FsaNumber should relate to a party record in our system, we return that.  How we return flavours of user will be interesting
      return new IntermediaryOwner("fred Jones", "12345", ownerId, this);
    }

    MsoCase ICaseRepository.GetCase(Guid caseId) {
      
      return new MsoCase(caseId, ((IOwnerRepository)this).GetOwner(Guid.NewGuid()), this);
    }

    List<CaseSummary> ICaseRepository.ListCasesForUser(Owner user) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="theCase"></param>
    /// <returns></returns>
    List<SolutionSummary> ICaseRepository.ListSolutions(MsoCase theCase) {

      // make sure the owner of the case passed in matches when calling the database
      var list = new List<SolutionSummary>();

      for (var x = 1; x < 5; x++) {
        var summary = new MortgageSolutionSummary(Guid.NewGuid(), 70000 * x, 34 * x, 95000 * x, (4 % x) == 0, DateTime.Now.AddDays(-x), false);

        list.Add(summary);
      }

      return list;
    }

    /// <summary>
    /// Get the solution for this case
    /// </summary>
    /// <param name="solutionId"></param>
    /// <returns></returns>
    Solution ICaseRepository.GetSolution(Guid solutionId) {
      // we would go to a database and get all these, ensuring user and the owner match
      var requirement = new MortgageRequirement(Guid.NewGuid(), 250000, 90, 400000, false, DateTime.Now.AddDays(-45));

      var product = _IntermediaryProductService.GetProductDetails(Guid.NewGuid());

      var productList = new List<Product> { product };

      var solution = new MortgageSolution(productList, requirement);


      return solution;
    }


  }
}