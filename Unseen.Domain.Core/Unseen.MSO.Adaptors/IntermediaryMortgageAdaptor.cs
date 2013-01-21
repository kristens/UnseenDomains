using System;
using System.Collections.Generic;
using System.IO;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Entities;
using Unseen.Domain.Core.Entities.Mortgage;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.Adaptors {
  public class IntermediaryMortgageAdaptor : IMortgageAdaptor
  {
    private readonly IMortgageProductService _productService;

    public IntermediaryMortgageAdaptor(IMortgageProductService productService)
    {
      _productService = productService;
      return;
      
    }

    SolutionDto IAdaptor.AdaptSolution(Solution domainSolution)
    {

      var dtoProducts = new List<ProductDto>();

      foreach (var product in domainSolution.Products)
      {
        dtoProducts.Add(((IMortgageAdaptor)this).AdaptProduct(product));
      }

      RequirementDto dtoRequirement = null; 
      if (domainSolution.Requirement is BuyToLetRequirement) {
        dtoRequirement = ((IMortgageAdaptor)this).AdaptRequirement((BuyToLetRequirement) domainSolution.Requirement);
      }
      else if (domainSolution.Requirement is RateSwitchRequirement){
        dtoRequirement = ((IMortgageAdaptor)this).AdaptRequirement((RateSwitchRequirement)domainSolution.Requirement);
      }
      else if (domainSolution.Requirement is HousePurchaseRequirement){
        dtoRequirement = ((IMortgageAdaptor)this).AdaptRequirement((HousePurchaseRequirement)domainSolution.Requirement);
      }
      else{
        throw new InvalidDataException("We shouldn't be here");
       }
      

      var dtoSolution = new MortgageSolutionDto(dtoProducts, (MortgageRequirementDto) dtoRequirement);

      return dtoSolution;
    }

    List<SolutionSummaryDto> IAdaptor.AdaptionSolutionSummary(List<SolutionSummary> domainSolutionSummary)
    {

      var dtoSummaryList = new List<SolutionSummaryDto>();

      foreach (MortgageSolutionSummary mortgageSummry in domainSolutionSummary)
      {
        var dtoSummary = new MortgageSolutionSummaryDto(mortgageSummry.Id, mortgageSummry.LoanAmount,
                                                        mortgageSummry.TermInMonths, mortgageSummry.PurchasePrice,
                                                        mortgageSummry.Recommended, mortgageSummry.CreatedDate,
                                                        mortgageSummry.Progressed);
        dtoSummaryList.Add(dtoSummary);
      }

      return dtoSummaryList;
    }

    ProductDto IAdaptor.AdaptProduct(Product domainProduct)
    {
      var mortgageProduct = (MortgageProduct) domainProduct;

      var dtoProduct = new MortgageProductDto(mortgageProduct.ErcApply, mortgageProduct.InterestRate, mortgageProduct.Id,
                                              mortgageProduct.Name, mortgageProduct.Description);

      return dtoProduct;
    }

    /// <summary>
    /// Return a requirement based on HP
    /// </summary>
    /// <param name="domainRequirement"></param>
    /// <returns></returns>
    RequirementDto IMortgageAdaptor.AdaptRequirement(HousePurchaseRequirement domainRequirement) {

      var mortgageRequirement = domainRequirement;

      var dtoRequirement = new MortgageRequirementDto(mortgageRequirement.Id, mortgageRequirement.LoanAmount, mortgageRequirement.TermInMonths,
                                                      mortgageRequirement.PurchasePrice, mortgageRequirement.Recommended,
                                                      mortgageRequirement.CreatedDate);

      return dtoRequirement;
    }


    /// <summary>
    /// return a requirement based on BTL
    /// </summary>
    /// <param name="domainRequirement"></param>
    /// <returns></returns>
    RequirementDto IMortgageAdaptor.AdaptRequirement(BuyToLetRequirement domainRequirement) {

      var mortgageRequirement = domainRequirement;

      var dtoRequirement = new MortgageRequirementDto(mortgageRequirement.MonthlyRental,mortgageRequirement.Id, mortgageRequirement.CreatedDate);

      return dtoRequirement;
    }


    /// <summary>
    /// return a requirement based on a rate switch
    /// </summary>
    /// <param name="domainRequirement"></param>
    /// <returns></returns>
    RequirementDto IMortgageAdaptor.AdaptRequirement(RateSwitchRequirement domainRequirement)
    {

      var mortgageRequirement = domainRequirement;

      var dtoRequirement = new MortgageRequirementDto(mortgageRequirement.AccountToSwitch, mortgageRequirement.Id, mortgageRequirement.CreatedDate);

      return dtoRequirement;
    }


    /// <summary>
    /// this needs to change to create the correct items based on the information passed in, implies we need a type on the dto
    /// </summary>
    /// <param name="dtoRequirement"></param>
    /// <returns></returns>
    Requirement IAdaptor.AdaptRequirement(RequirementDto dtoRequirement) {
      var mortgageRequirementDto = (MortgageRequirementDto)dtoRequirement;

      var requirement = new HousePurchaseRequirement( mortgageRequirementDto.Id, mortgageRequirementDto.LoanAmount, mortgageRequirementDto.TermInMonths,
                                                      mortgageRequirementDto.PurchasePrice, mortgageRequirementDto.Recommended,
                                                      mortgageRequirementDto.CreatedDate,_productService);

      return requirement;
    }

    List<ProductSummaryDto> IAdaptor.AdaptProductSummary(List<ProductSummary> domainProductSummary)
    {
      var productSummaries = new List<ProductSummaryDto>();

      foreach (MortgageProductSummary summary in domainProductSummary)
      {
        var dtoProductSummary = new MortgageProductSummaryDto(summary.ErcApply, summary.InterestRate, summary.Id,
                                                              summary.Name, summary.Description);

        productSummaries.Add(dtoProductSummary);
      }

      return productSummaries;
    }

    List<CaseSummaryDTO> IAdaptor.AdaptCaseSummary(List<CaseSummary> domainCaseSummaries) {
      throw new NotImplementedException();
    }
  }
}
