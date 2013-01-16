using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs {
  public abstract class SolutionSummaryDto {

    protected SolutionSummaryDto()
    {
        
    }

    protected SolutionSummaryDto(Guid id, DateTime createdDate, bool progessed)
    {
      Id = id;
      CreatedDate = createdDate;
      Progressed = progessed;

      return;
    }

    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Progressed { get; set; }
  }
}
