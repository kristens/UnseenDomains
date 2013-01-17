using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core.Entities;

namespace Unseen.Domain.Core.Abstractions {
  public interface IOwnerRepository
  {

    Owner GetOwner(Guid ownerId);
  }
}
