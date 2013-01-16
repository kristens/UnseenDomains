using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.MSO.Core.DTOs.Intermediary {
  public class IntermediaryCaseDto: CaseDto {

    public IntermediaryCaseDto()
    {
        
    }

    public IntermediaryCaseDto(Guid id, UserDto owner):base(id, owner)
    {
      

      return;
    }

    
  }
}
