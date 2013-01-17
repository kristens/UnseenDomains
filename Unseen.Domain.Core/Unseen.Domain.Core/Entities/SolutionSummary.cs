using System;

namespace Unseen.Domain.Core.Entities {
  public abstract class SolutionSummary {

    protected SolutionSummary(Guid id, DateTime createdDate, bool progessed)
    {
      Id = id;
      CreatedDate = createdDate;
      Progressed = progessed;

      return;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public bool Progressed { get; private set; }
  }
}
