using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unseen.MSO.Core.DTOs {
  public class CaseDto {

    public CaseDto()
    {
      
    }

    public CaseDto(Guid id, UserDto owner)
    {
      Id = id;
      Owner = owner;
      return;
    }

    public Guid Id { get; private set; }
    public UserDto Owner { get; private set; }
  }
}
