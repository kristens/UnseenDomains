using System;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities {
  public class IntermediaryOwner: Owner {

    public IntermediaryOwner(string name, string fsaNumber, Guid id, ICaseRepository caseRepository)
      : base(caseRepository, id)
    {
      Name = name;
      FsaNumber = fsaNumber;

      return;
    }


    public string Name { get; private set; }

    public string FsaNumber { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {

      if ((obj == null) || (!(obj is IntermediaryOwner)))
      {
        return false;
      }

      return FsaNumber == ((IntermediaryOwner)obj).FsaNumber;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
      return FsaNumber.GetHashCode();
    }
  }
}
