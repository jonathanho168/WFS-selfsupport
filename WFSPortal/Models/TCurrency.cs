using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCurrency")]
[Index("CurrencyGuid", Name = "RG_tCurrency", IsUnique = true)]
public partial class TCurrency
{
    [Key]
    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    [StringLength(4)]
    public string? Symbol { get; set; }

    [Column("CurrencyGUID")]
    public Guid CurrencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CurrencyDescription { get; set; }

    [InverseProperty("BenefitCurrencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();

    [InverseProperty("ClassCurrencyCodeNavigation")]
    public virtual ICollection<TClass> TClasses { get; set; } = new List<TClass>();

    [InverseProperty("PayoutCurrencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("CountryCurrencyCodeNavigation")]
    public virtual ICollection<TCountry> TCountries { get; set; } = new List<TCountry>();

    [InverseProperty("CourseCurrencyCodeNavigation")]
    public virtual ICollection<TCourse> TCourses { get; set; } = new List<TCourse>();

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<TCurrencyConversion> TCurrencyConversions { get; set; } = new List<TCurrencyConversion>();

    [InverseProperty("GradeCurrencyCodeNavigation")]
    public virtual ICollection<TGradeHist> TGradeHists { get; set; } = new List<TGradeHist>();

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<TPayrollVendorAccumulatorType> TPayrollVendorAccumulatorTypes { get; set; } = new List<TPayrollVendorAccumulatorType>();

    [InverseProperty("AmountCurrencyCodeNavigation")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();

    [InverseProperty("RequestedPayCurrencyCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("PersonBasePayCurrencyCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHists { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("PersonBenefitClaimCurrencyCodeNavigation")]
    public virtual ICollection<TPersonBenefitClaim> TPersonBenefitClaims { get; set; } = new List<TPersonBenefitClaim>();

    [InverseProperty("PaymentCurrencyCodeNavigation")]
    public virtual ICollection<TPersonBenefitCobrapayment> TPersonBenefitCobrapayments { get; set; } = new List<TPersonBenefitCobrapayment>();

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("PayoutCurrencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("PersonOtherPayCurrencyCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPersonOtherPayCurrencyCodeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PlannedCurrencyCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPlannedCurrencyCodeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("CsfAnzTaxCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTax> TPersonTaxes { get; set; } = new List<TPersonTax>();

    [InverseProperty("NextEmployerSalaryCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminationNextEmployerSalaryCurrencyCodeNavigations { get; set; } = new List<TPersonTermination>();

    [InverseProperty("SeverancePayCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminationSeverancePayCurrencyCodeNavigations { get; set; } = new List<TPersonTermination>();

    [InverseProperty("UnusedVacationPayCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminationUnusedVacationPayCurrencyCodeNavigations { get; set; } = new List<TPersonTermination>();

    [InverseProperty("PersonTrainingExpenseCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTrainingExpense> TPersonTrainingExpenses { get; set; } = new List<TPersonTrainingExpense>();

    [InverseProperty("PersonTrainingCurrencyCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();

    [InverseProperty("PersonYearToDateEarningsCurrencyCodeNavigation")]
    public virtual ICollection<TPersonYearToDateEarning> TPersonYearToDateEarnings { get; set; } = new List<TPersonYearToDateEarning>();

    [InverseProperty("PositionBudgetCurrencyCodeNavigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHists { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("ProjectBudgetCurrencyCodeNavigation")]
    public virtual ICollection<TProject> TProjects { get; set; } = new List<TProject>();

    [InverseProperty("PaymentAmountCurrencyCodeNavigation")]
    public virtual ICollection<TRecruitingAgreement> TRecruitingAgreements { get; set; } = new List<TRecruitingAgreement>();

    [InverseProperty("AllocationAmountCurrencyCodeNavigation")]
    public virtual ICollection<TRecruitingExpenseAllocation> TRecruitingExpenseAllocations { get; set; } = new List<TRecruitingExpenseAllocation>();

    [InverseProperty("ExpenseAmountCurrencyCodeNavigation")]
    public virtual ICollection<TRecruitingExpense> TRecruitingExpenses { get; set; } = new List<TRecruitingExpense>();

    [InverseProperty("SurveyCurrencyCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlan> UsysSalaryPlans { get; set; } = new List<UsysSalaryPlan>();

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<UsysTimeCostModel> UsysTimeCostModels { get; set; } = new List<UsysTimeCostModel>();
}
