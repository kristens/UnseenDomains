using System;
using System.Collections.Generic;

using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;

namespace Unseen.MSO.Core.Repositories {

  /// <summary>
  /// Sits over our database and returns the party information that relates to the owner of this case
  /// </summary>
  public class MsoRepository : IOwnerRepository, ICaseRepository 
  {
    private IProductService _ProductService;

    public MsoRepository(IProductService productService)
    {
      _ProductService = productService;

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
    Solution ICaseRepository.GetSolution(Guid solutionId)
    {

      var hpSolution = new Guid("1F86D309-EAE1-47CD-BE03-1064E3CC5AE8");
      var btlSolution = new Guid("2386D309-EAE1-47CD-BE03-1064E3CC5AE8");
      var rateSwitchSolution = new Guid("4486D309-EAE1-47CD-BE03-1064E3CC5AE8");

      MortgageRequirement requirement = null;

      if (solutionId == hpSolution)
      {
        // we would go to a database and get all these, ensuring user and the owner match
        requirement = new HousePurchaseRequirement(Guid.NewGuid(), 250000, 90, 400000, false,
                                                   DateTime.Now.AddDays(-45));
      }
      else if (solutionId == btlSolution)
      {
        requirement = new BuyToLetRequirement(Guid.NewGuid(), 1000, DateTime.Now.AddDays(-3));
      }
      else if (solutionId == rateSwitchSolution)
      {
        requirement = new RateSwitchRequirement(Guid.NewGuid(), "122222", DateTime.Now.AddDays(-5));
      }

      var product = _ProductService.GetProductDetails(Guid.NewGuid());

      var productList = new List<Product> { product };

      var solution = new MortgageSolution(productList, requirement);

      return solution;
    }


  }
}
