using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;
using Unseen.MSO.Core.DTOs;

namespace Unseen.MSO.Core.Abstraction {
  public interface IMortgageAdaptor: IAdaptor {

    RequirementDto AdaptRequirement(HousePurchaseRequirement domainRequirement);

    RequirementDto AdaptRequirement(BuyToLetRequirement domainRequirement);

    RequirementDto AdaptRequirement(RateSwitchRequirement domainRequirement);

  }
}
