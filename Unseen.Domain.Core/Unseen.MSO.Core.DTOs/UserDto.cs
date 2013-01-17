using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs {
  public abstract class UserDto {

    public UserDto(Guid id)
    {
      Id = id;
      return;
    }

    public Guid Id { get; private set; }
  
  }
}
