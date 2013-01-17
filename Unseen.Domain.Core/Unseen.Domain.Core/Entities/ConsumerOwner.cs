using System;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities {
  public class ConsumerOwner: Owner
  {


    public ConsumerOwner(string userName, Guid id, ICaseRepository caseRepository): base (caseRepository, id)
    {
      UserName = userName;

      return;
    }

    public string UserName { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj) {

      if ((obj == null) || (!(obj is ConsumerOwner))) {
        return false;
      }

      return (string.Compare(UserName, ((ConsumerOwner)obj).UserName, StringComparison.CurrentCultureIgnoreCase) == 0);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode() {
      return UserName.GetHashCode();
    }
  }
}
