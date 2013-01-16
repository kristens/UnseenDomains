using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs.Intermediary {
  public class IntermediaryUserDto : UserDto {

    public IntermediaryUserDto(string name, string id)
    {
      Name = name;
      Id = id;

      return;
    }


    public string Name { get; private set; }

    public string Id { get; private set; }
  }
}
