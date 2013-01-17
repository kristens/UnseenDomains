using System;
using System.Collections.Generic;
using System.Security;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities {
  public abstract class Owner
  {

    protected ICaseRepository _CaseRepostory;

    protected Owner(ICaseRepository caseRepository, Guid id)
    {
      _CaseRepostory = caseRepository;
      Id = id;
      return;
    }

    public abstract override bool Equals(object obj);
    public abstract override int GetHashCode();

    public Guid Id { get; private set; }

    /// <summary>
    /// List the active cases
    /// </summary>
    /// <returns></returns>
    public virtual List<CaseSummary> ListActiveCases()
    {
      return _CaseRepostory.ListCasesForUser(this);
    }

    public MsoCase GetCase(Guid caseId)
    {
      var targetCase = _CaseRepostory.GetCase(caseId);

      if (!Equals(targetCase.Owner))
      {
        throw new SecurityException("user x is not allowed to open another case");
      }

      return targetCase;
    }

    //public abstract bool SuspendUser();
  }
}
