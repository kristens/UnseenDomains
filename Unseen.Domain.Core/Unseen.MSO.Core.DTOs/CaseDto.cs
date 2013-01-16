using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public abstract class CaseDto {

    protected CaseDto()
    {
      
    }

    protected CaseDto(Guid id, UserDto owner)
    {
      Id = id;
      Owner = owner;

      return;
    }

    public Guid Id { get; set; }

    public UserDto Owner { get; set; }
  }
}
