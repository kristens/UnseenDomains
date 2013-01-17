using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs {
  public class CaseSummaryDTO {
    public CaseSummaryDTO(string friendlyId, Guid caseId, DateTime createdDate, int state)
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
