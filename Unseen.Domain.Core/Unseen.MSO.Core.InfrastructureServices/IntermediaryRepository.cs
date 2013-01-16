using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.Abstraction.Intermediary;

namespace Unseen.MSO.Core.InfrastructureServices {
  public class IntermediaryRepository : IIntermediaryRepository {

    IntermediaryUser IIntermediaryRepository.GetIntermediary(string fsaNumber) {
      

      return new IntermediaryUser("Fred Jones", "fsa1234");
    }
  }
}
