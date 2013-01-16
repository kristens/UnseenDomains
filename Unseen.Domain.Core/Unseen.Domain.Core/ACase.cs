using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.Domain.Core {
  public abstract class aCase {

    protected aCase(Guid id, User user)
    {
      Id = id;
      User = user;

      return;
    }

    /// <summary>
    /// Id of the case
    /// </summary>
    public Guid Id { get; private set; }

    public User User { get; private set; }

  }
}
