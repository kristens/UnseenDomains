using System;

namespace Unseen.Domain.Core.Entities {
  public class CaseSummary {

    public CaseSummary(string friendlyId, Guid caseId, DateTime createdDate, int state)
    {
      FriendlyId = friendlyId;
      CaseId = caseId;
      CreatedDate = createdDate;
      State = state;

      return;
    }
    public string FriendlyId { get; private set; }
    public Guid CaseId { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public int State { get; private set; }
  }
}
