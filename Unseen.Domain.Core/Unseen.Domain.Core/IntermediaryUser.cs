using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unseen.Domain.Core {
  public class IntermediaryUser: User {

    public IntermediaryUser(string name, string id)
    {
      Name = name;
      Id = id;

      return;
    }


    public string Name { get; private set; }

    public string Id { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {

      if ((obj == null) || (!(obj is IntermediaryUser)))
      {
        return false;
      }

      return Id == ((IntermediaryUser)obj).Id;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}
