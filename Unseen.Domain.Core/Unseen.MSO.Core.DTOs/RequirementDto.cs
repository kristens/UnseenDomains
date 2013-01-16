using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public abstract class RequirementDto {

    protected RequirementDto()
    {
      
    }
    protected RequirementDto(Guid id, DateTime createdDate)
    {
      Id = id;
      CreatedDate = createdDate;

      return;
    }
    public Guid Id { get; private set; }

    public DateTime CreatedDate { get; private set; }
  }

}
