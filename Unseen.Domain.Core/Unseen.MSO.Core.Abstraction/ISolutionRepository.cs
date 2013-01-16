using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;

namespace Unseen.MSO.Core.Abstraction {
  public interface ISolutionRepository {

    List<SolutionSummary> List(aCase theCase);

    Solution Get(Guid solutionId);
  }
}
