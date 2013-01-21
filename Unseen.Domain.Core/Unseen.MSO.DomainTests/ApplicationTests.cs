using System;
using Unseen.MSO.ApplicationServices.Intermediary;
using Unseen.MSO.Bindings;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;
using Unseen.MSO101.Bindings;
using Unseen.MSO101.Core.DTOs;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unseen.MSO.DomainTests {
  [TestClass]
  public class ApplicationTests
  {
    [TestMethod]
    public void RetrieveSolutionSummary()
    {

      var bindings = new DefaultBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);

      var owner = new IntermediaryUserDto("Fred Jones", "fsa1234", Guid.NewGuid());
      var targetCase = new CaseDto(Guid.NewGuid(), owner);

      var summaries = service.ListSolutionsForCase(targetCase);

      Assert.IsNotNull(summaries, "Should have had some summaries back");
      Assert.IsTrue(summaries.Count > 0, "Should have had some summaries returned");

      return;
    }

    [TestMethod]
    public void RetrieveRateSwitchSolutionDetail() {
      var bindings = new DefaultBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);
      var owner = new IntermediaryUserDto("Fred Jones", "fsa1234", Guid.NewGuid());
      var targetCase = new CaseDto(Guid.NewGuid(), owner);

      var solutionDetail = service.GetSolution(new Guid("2386D309-EAE1-47CD-BE03-1064E3CC5AE8"), targetCase);

      Assert.IsNotNull(solutionDetail, "Should have had a solution");
      Assert.IsNotNull(solutionDetail.Products, "Should have had some products returned");
      Assert.IsTrue(solutionDetail.Products.Count == 1, "Only one product on this solution");
      Assert.IsNotNull(solutionDetail.Requirement, "should have a requirement");
      Assert.IsInstanceOfType(solutionDetail.Requirement, typeof(MortgageRequirementDto), "Should be a mortgage requirement");
      Assert.AreEqual("122222", ((MortgageRequirementDto)solutionDetail.Requirement).AccountToSwitch, "Rate switch should be populated");
      return;
    }

    [TestMethod]
    public void RetrieveBtlSolutionDetail() {
      var bindings = new DefaultBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);
      var owner = new IntermediaryUserDto("Fred Jones", "fsa1234", Guid.NewGuid());
      var targetCase = new CaseDto(Guid.NewGuid(), owner);

      var solutionDetail = service.GetSolution(new Guid("4486D309-EAE1-47CD-BE03-1064E3CC5AE8"), targetCase);

      Assert.IsNotNull(solutionDetail, "Should have had a solution");
      Assert.IsNotNull(solutionDetail.Products, "Should have had some products returned");
      Assert.IsTrue(solutionDetail.Products.Count == 1, "Only one product on this solution");
      Assert.IsNotNull(solutionDetail.Requirement, "should have a requirement");
      Assert.IsInstanceOfType(solutionDetail.Requirement, typeof(MortgageRequirementDto), "Should be a mortgage requirement");
      Assert.AreEqual(1000, ((MortgageRequirementDto)solutionDetail.Requirement).MonthlyRental, "BTL should be populated");
      return;
    }

    [TestMethod]
    public void RetrieveHpSolutionDetail()
    {
      var bindings = new DefaultBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);
      var owner = new IntermediaryUserDto("Fred Jones", "fsa1234", Guid.NewGuid());
      var targetCase = new CaseDto(Guid.NewGuid(), owner);

      var solutionDetail = service.GetSolution(new Guid("1F86D309-EAE1-47CD-BE03-1064E3CC5AE8"), targetCase);

      Assert.IsNotNull(solutionDetail, "Should have had a solution");
      Assert.IsNotNull(solutionDetail.Products, "Should have had some products returned");
      Assert.IsTrue(solutionDetail.Products.Count == 1, "Only one product on this solution");
      Assert.IsNotNull(solutionDetail.Requirement, "should have a requirement");
      Assert.IsInstanceOfType(solutionDetail.Requirement, typeof(MortgageRequirementDto),"Should be a mortgage requirement" );
      Assert.IsTrue(((MortgageRequirementDto)solutionDetail.Requirement).LoanAmount > 0, "HP should be populated");
      return;
    }

    [TestMethod]
    public void ListSuitableProducts()
    {
      var bindings = new DefaultBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);

      var requirements = new MortgageRequirementDto();
      requirements.LoanAmount = 250000;
      requirements.PurchasePrice = 400000;
      requirements.TermInMonths = 256;

      var suitableProducts = service.ListSuitableProduct(requirements);

      Assert.IsNotNull(suitableProducts, "Products should have been returned");
      Assert.IsTrue(suitableProducts.Count > 0, "AT least one product should have been returned.");

      return;
      
    }

    [TestMethod]
    public void TestShoeSizePresent()
    {
      var bindings = new UnseenBindings();
      var service = IntermediaryFactory.GetModellingService(bindings);

      var requirements = new UnseenMortgageRequirementDto();
      requirements.LoanAmount = 250000;
      requirements.PurchasePrice = 400000;
      requirements.TermInMonths = 256;
      requirements.ShoeSize = 23;

      var suitableProducts = service.ListSuitableProduct(requirements);

      Assert.IsNotNull(suitableProducts, "Products should have been returned");
      Assert.IsTrue(suitableProducts.Count > 0, "AT least one product should have been returned.");

      Assert.IsTrue(suitableProducts.Any( a => a.Name.Contains("ShoeSize")), "Should have had one returned");

      return;
    }

  }
}
