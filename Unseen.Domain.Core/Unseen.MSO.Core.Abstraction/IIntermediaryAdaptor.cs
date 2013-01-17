using Unseen.Domain.Core;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.Core.Abstraction {
  public interface IIntermediaryAdaptor: IAdaptor
  {

    IntermediaryDetails AdaptIntermediaryDetails(IntermediaryDetailsDto intermediaryDetailsDto);
  }
}
