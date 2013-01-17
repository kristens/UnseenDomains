﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.Abstraction.Consumer;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.InfrastructureServices;

namespace Unseen.MSO.Core.Repositories
{
  public class MortgageSolutionRepository: IIntermediarySolutionRepository, IConsumerSolutionRepository
  {

    private IIntermediaryProductService _IntermediaryProductService;
    private IConsumerProductService _ConsumerProductService;

    public MortgageSolutionRepository( IIntermediaryProductService intermediaryProductService, IConsumerProductService consumerProductService)
    {
      _IntermediaryProductService = intermediaryProductService;
      _ConsumerProductService = consumerProductService;

      return;
    }
   
    /// <summary>
    /// 
    /// </summary>
    /// <param name="theCase"></param>
    /// <returns></returns>
    List<SolutionSummary> IIntermediarySolutionRepository.List(IntermediaryCase theCase)
    {

      // make sure the owner of the case passed in matches when calling the database
      var list = new List<SolutionSummary>();

      for (var x = 1; x < 5; x++)
      {
        var summary = new MortgageSolutionSummary(Guid.NewGuid(), 70000*x, 34*x, 95000*x, (4%x) == 0, DateTime.Now.AddDays(-x), false);

        list.Add(summary);
      }

      return list;
    }


    Solution IIntermediarySolutionRepository.Get(Guid solutionId)
    {
      // we would go to a database and get all these, ensuring user and the owner match
      var requirement = new MortgageRequirement(Guid.NewGuid(), 250000, 90, 400000, false, DateTime.Now.AddDays(-45));

      var product = _IntermediaryProductService.GetProduct(Guid.NewGuid());

      var productList = new List<Product>{product};

      var solution = new MortgageSolution(productList, requirement);
      
 
      return solution;
    }


    List<Solution> IConsumerSolutionRepository.List(aCase theCase) {
      throw new NotImplementedException();
    }
  }
}
