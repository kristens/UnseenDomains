using System;
using System.Collections.Generic;
using Unseen.Domain.Core.Abstractions;
using Unseen.Domain.Core.Abstractions.Intermediary;
using Unseen.Domain.Core.Entities;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.Adaptors {
  public class IntermediaryMortgageAdaptor : IIntermediaryAdaptor
  {
    private readonly IIntermediaryMortgageProductService _productService;

    public IntermediaryMortgageAdaptor(IIntermediaryMortgageProductService productService)
    {
      _productService = productService;
      return;
      
    }
    SolutionDto IAdaptor.AdaptSolution(Solution domainSolution)
    {

      var dtoProducts = new List<ProductDto>();

      foreach (var product in domainSolution.Products)
      {
        dtoProducts.Add(((IIntermediaryAdaptor)this).AdaptProduct(product));
      }

      var dtoRequirement = ((IIntermediaryAdaptor)this).AdaptRequirement(domainSolution.Requirement);

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

    RequirementDto IAdaptor.AdaptRequirement(Requirement domainRequirement)
    {

      var mortgageRequirement = (MortgageRequirement) domainRequirement;

      var dtoRequirement = new MortgageRequirementDto(mortgageRequirement.Id, mortgageRequirement.LoanAmount, mortgageRequirement.TermInMonths,
                                                      mortgageRequirement.PurchasePrice, mortgageRequirement.Recommended,
                                                      mortgageRequirement.CreatedDate);

      return dtoRequirement;
    }

    Requirement IAdaptor.AdaptRequirement(RequirementDto dtoRequirement) {
      var mortgageRequirementDto = (MortgageRequirementDto)dtoRequirement;

      var requirement = new MortgageRequirement(mortgageRequirementDto.Id, mortgageRequirementDto.LoanAmount, mortgageRequirementDto.TermInMonths,
                                                      mortgageRequirementDto.PurchasePrice, mortgageRequirementDto.Recommended,
                                                      mortgageRequirementDto.CreatedDate,_productService);

      return requirement;
    }

    IntermediaryDetails IIntermediaryAdaptor.AdaptIntermediaryDetails(IntermediaryDetailsDto intermediaryDetailsDto)
    {
      var intermediaryDetails = new IntermediaryDetails(intermediaryDetailsDto.MortgageClub);

      return intermediaryDetails;
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
