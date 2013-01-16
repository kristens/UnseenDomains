using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.Domain.Core {
  public class ConsumerUser: User {

    public ConsumerUser(string userName)
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

      if ((obj == null) || (!(obj is ConsumerUser))) {
        return false;
      }

      return (string.Compare(UserName, ((ConsumerUser)obj).UserName, StringComparison.CurrentCultureIgnoreCase) == 0);
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
