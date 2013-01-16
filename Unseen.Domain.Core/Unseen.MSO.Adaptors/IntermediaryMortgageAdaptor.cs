using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unseen.Domain.Core;
using Unseen.MSO.Core.Abstraction;
using Unseen.MSO.Core.Abstraction.Intermediary;
using Unseen.MSO.Core.DTOs;
using Unseen.MSO.Core.DTOs.Intermediary;

namespace Unseen.MSO.Adaptors {
  public class IntermediaryMortgageAdaptor : IIntermediaryAdaptor {

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

    Solution IAdaptor.AdaptSolution(SolutionDto dtoSolution) {
      var products = new List<Product>();

      foreach (var product in dtoSolution.Products) {
        products.Add(((IIntermediaryAdaptor)this).AdaptProduct(product));
      }

      var requirement = ((IIntermediaryAdaptor)this).AdaptRequirement(dtoSolution.Requirement);

      var solution = new MortgageSolution(products, (MortgageRequirement)requirement);

      return solution;
    }

    aCase IAdaptor.AdaptCase(CaseDto caseDto)
    {
      var intermediaryDto = (IntermediaryCaseDto) caseDto;
      var dtoIntermediary = (IntermediaryUserDto) caseDto.Owner;

      var intermediaryOwner = new IntermediaryUser(dtoIntermediary.Name, dtoIntermediary.Id);
      var intermediaryCase = new IntermediaryCase(intermediaryDto.Id, intermediaryOwner);

      return intermediaryCase;
    }

    CaseDto IAdaptor.AdaptCase(aCase domainCase)
    {

      var intermediaryDomainCase = (IntermediaryCase) domainCase;
      var intermediaryDomainUser = (IntermediaryUser)domainCase.User;

      var ownerDto = new IntermediaryUserDto(intermediaryDomainUser.Name, intermediaryDomainUser.Id);
      var dto = new IntermediaryCaseDto(intermediaryDomainCase.Id, ownerDto);

      return dto;
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

    UserDto IAdaptor.AdaptOwner(User domainUser)
    {

      var intermediary = (IntermediaryUser)domainUser;

      var dtoIntermediary = new IntermediaryUserDto(intermediary.Name, intermediary.Id);

      return dtoIntermediary;
    }

    User IAdaptor.AdaptOwner(UserDto ownerDto)
    {
      var dtoIntermediary = (IntermediaryUserDto) ownerDto;
      var domainIntermediary = new IntermediaryUser(dtoIntermediary.Name, dtoIntermediary.Id);

      return domainIntermediary;
    }

    ProductDto IAdaptor.AdaptProduct(Product domainProduct)
    {
      var mortgageProduct = (MortgageProduct) domainProduct;

      var dtoProduct = new MortgageProductDto(mortgageProduct.ErcApply, mortgageProduct.InterestRate, mortgageProduct.Id,
                                              mortgageProduct.Name, mortgageProduct.Description);

      return dtoProduct;
    }

    Product IAdaptor.AdaptProduct(ProductDto dtoProduct) {
      var mortgageProductDto = (MortgageProductDto) dtoProduct;

      var domainProduct = new MortgageProduct(mortgageProductDto.ErcApply, mortgageProductDto.InterestRate, mortgageProductDto.Id,
                                              mortgageProductDto.Name, mortgageProductDto.Description);

      return domainProduct;
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
                                                      mortgageRequirementDto.CreatedDate);

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
  }
}
