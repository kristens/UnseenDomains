using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.Domain.Core {
  public abstract class User {

    public abstract override bool Equals(object obj);
    public abstract override int GetHashCode();
    
  }
}
