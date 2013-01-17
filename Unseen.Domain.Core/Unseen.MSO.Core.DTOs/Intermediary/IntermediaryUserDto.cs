using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs.Intermediary {
  public class IntermediaryUserDto : UserDto {

    public IntermediaryUserDto(string name, string fsaNumber, Guid id): base(id)
    {
      Name = name;
      FsaNumber = fsaNumber;

      return;
    }


    public string Name { get; private set; }

    public string FsaNumber { get; private set; }
  }
}
