using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.Domain.Core {
  public abstract class  Requirement {

    protected Requirement(Guid id, DateTime createdDate)
    {
      Id = id;
      CreatedDate = createdDate;

      return;
    }
    public Guid Id { get; private set; }

    public DateTime CreatedDate { get; private set; }
  }
}
