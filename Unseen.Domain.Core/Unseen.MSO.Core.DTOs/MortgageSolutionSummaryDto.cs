﻿using System;

namespace Unseen.MSO.Core.DTOs {
  public class MortgageSolutionSummaryDto: SolutionSummaryDto {
    public MortgageSolutionSummaryDto()
    {
        
    }

    public MortgageSolutionSummaryDto(Guid id, decimal loanAmount, int termInMonths, decimal purchasePrice, bool recommended, DateTime createdDate, bool progressed): base(id, createdDate, progressed)
    {
      LoanAmount = loanAmount;
      TermInMonths = termInMonths;
      PurchasePrice = purchasePrice;
      Recommended = recommended;

      return;
    }


    public Decimal LoanAmount { get; private set; }
    public int TermInMonths { get; private set; }
    public Decimal PurchasePrice { get; private set; }
    public bool Recommended { get; private set; }
  }
  
}
