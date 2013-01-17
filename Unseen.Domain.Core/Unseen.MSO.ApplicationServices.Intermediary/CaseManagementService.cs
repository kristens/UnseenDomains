using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Intermediary;

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
