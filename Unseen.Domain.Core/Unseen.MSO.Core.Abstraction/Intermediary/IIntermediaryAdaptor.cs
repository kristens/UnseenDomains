using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.Core.Abstraction.Intermediary {
  public interface IIntermediaryAdaptor: IAdaptor
  {

    IntermediaryDetails AdaptIntermediaryDetails(IntermediaryDetailsDto intermediaryDetailsDto);
  }
}
