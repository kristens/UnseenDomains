using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;

namespace Unseen.Domain.Core.Entities {
  public class MsoCase
  {

    private ICaseRepository _caseRepository;

    public MsoCase(Guid id, Owner user)
    {
      Id = id;
      Owner = user;
      return;
    }

    public MsoCase(Guid id, Owner user, ICaseRepository caseRepository)
      : this(caseRepository) {
      Id = id;
      Owner = user;
      return;
    }

    public MsoCase(ICaseRepository caseRepository)
    {
      _caseRepository = caseRepository;
      return;
    }


    /// <summary>
    /// FsaNumber of the case
    /// </summary>
    public Guid Id { get; private set; }

    public Owner Owner { get; private set; }

    /// <summary>
    /// return all the solutions for this case
    /// </summary>
    /// <returns></returns>
    public virtual List<SolutionSummary> ListSolutions()
    {
      return _caseRepository.ListSolutions(this);
    }

    public virtual Solution GetSolution(Guid solutionId)
    {
      return _caseRepository.GetSolution(solutionId);
    }

    public virtual Guid AddSolution(Solution solution)
    {
      return Guid.NewGuid();
    }
  }
}
