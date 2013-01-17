using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Entities;

namespace Unseen.Domain.Core.Abstractions {
  public interface ICaseRepository
  {
    /// <summary>
    /// Load a case
    /// </summary>
    /// <param name="caseId"></param>
    /// <returns></returns>
    MsoCase GetCase(Guid caseId);


    /// <summary>
    /// list the cases for an individual
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    List<CaseSummary> ListCasesForUser(Owner user);

    /// <summary>
    /// List Solutions for case
    /// </summary>
    /// <param name="theCase"></param>
    /// <returns></returns>
    List<SolutionSummary> ListSolutions(MsoCase theCase);

    /// <summary>
    /// Get a solution for a case
    /// </summary>
    /// <param name="solutionId"></param>
    /// <returns></returns>
    Solution GetSolution(Guid solutionId);
  }
}
