using Unseen.Domain.Core.Abstractions;

namespace Unseen.MSO.ApplicationServices.Intermediary {
  public class CaseManagementService
  {

    private ICaseRepository _caseRepository;

    public CaseManagementService(ICaseRepository caseRepository)
    {
      _caseRepository = caseRepository;

      return;
    }

    
  }
}
