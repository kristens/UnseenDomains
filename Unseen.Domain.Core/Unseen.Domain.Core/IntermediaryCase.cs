using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.Domain.Core {
  public class IntermediaryCase : aCase {

    public IntermediaryCase(Guid id, IntermediaryUser user)
      : base(id, user)
    {
        
    }

  }
}
