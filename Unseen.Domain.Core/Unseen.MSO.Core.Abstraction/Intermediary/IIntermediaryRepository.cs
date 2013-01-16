using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;

namespace Unseen.MSO.Core.Abstraction.Intermediary {
  public interface IIntermediaryRepository
  {

    IntermediaryUser GetIntermediary(string fsaNumber);
  }
}
