namespace Unseen.Domain.Core.Entities {
  public class IntermediaryDetails {

    public IntermediaryDetails(string mortgageClub)
    {
      MortgageClub = mortgageClub;

      return;
    }

    public string MortgageClub { get; private set; }
  }
}
