using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;

namespace Unseen.MSO.Core.Abstraction.Consumer {
  public interface IConsumerSolutionRepository
  {

    List<Solution> List(aCase theCase);
  }
}
