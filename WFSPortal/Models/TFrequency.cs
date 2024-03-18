using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFrequency")]
[Index("FrequencyGuid", Name = "RG_tFrequency", IsUnique = true)]
public partial class TFrequency
{
    [Key]
    [StringLength(15)]
    public string FrequencyCode { get; set; } = null!;

    [Column("FrequencyGUID")]
    public Guid FrequencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? FrequencyAdjective { get; set; }

    public string? FrequencyDescription { get; set; }

    [InverseProperty("AutoEnrollmentEffectiveFromHireFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistAutoEnrollmentEffectiveFromHireFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("BenefitFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistBenefitFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("EmployeeContributionFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistEmployeeContributionFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("EmployerContributionFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistEmployerContributionFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("FlexCreditFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistFlexCreditFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("ImputedFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistImputedFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("PremiumFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistPremiumFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("WaitingPeriodFrequencyCodeNavigation")]
    public virtual ICollection<TBenefitHist> TBenefitHistWaitingPeriodFrequencyCodeNavigations { get; set; } = new List<TBenefitHist>();

    [InverseProperty("FromFrequencyCodeNavigation")]
    public virtual ICollection<TFrequencyConversion> TFrequencyConversionFromFrequencyCodeNavigations { get; set; } = new List<TFrequencyConversion>();

    [InverseProperty("ToFrequencyCodeNavigation")]
    public virtual ICollection<TFrequencyConversion> TFrequencyConversionToFrequencyCodeNavigations { get; set; } = new List<TFrequencyConversion>();

    [InverseProperty("GradeFrequencyCodeNavigation")]
    public virtual ICollection<TGradeHist> TGradeHists { get; set; } = new List<TGradeHist>();

    [InverseProperty("AmountFrequencyCodeNavigation")]
    public virtual ICollection<TPersonApplicationOffer> TPersonApplicationOffers { get; set; } = new List<TPersonApplicationOffer>();

    [InverseProperty("RequestedPayFrequencyCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("PersonBasePayFrequencyCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHistPersonBasePayFrequencyCodeNavigations { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("PersonBasePayPayrollFrequencyCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHistPersonBasePayPayrollFrequencyCodeNavigations { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("EndingPayFrequencyCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHistEndingPayFrequencyCodeNavigations { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("StartingPayFrequencyCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHistStartingPayFrequencyCodeNavigations { get; set; } = new List<TPersonEmploymentHist>();

    [InverseProperty("PersonOtherPayFrequencyCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPersonOtherPayFrequencyCodeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PersonOtherPayPayrollFrequencyCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPersonOtherPayPayrollFrequencyCodeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PlannedFrequencyCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHistPlannedFrequencyCodeNavigations { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("NextEmployerSalaryFrequencyCodeNavigation")]
    public virtual ICollection<TPersonTermination> TPersonTerminations { get; set; } = new List<TPersonTermination>();

    [InverseProperty("PayRateFrequencyCodeNavigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHists { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("PositionFundingFrequencyCodeNavigation")]
    public virtual ICollection<TPositionFundingHist> TPositionFundingHists { get; set; } = new List<TPositionFundingHist>();

    [InverseProperty("SurveyFrequencyCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("TargetFrequencyCodeNavigation")]
    public virtual ICollection<TSurveyFilterSet> TSurveyFilterSets { get; set; } = new List<TSurveyFilterSet>();

    [InverseProperty("AmountChangeFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayDetail> UsysSalaryPlanBasePayDetails { get; set; } = new List<UsysSalaryPlanBasePayDetail>();

    [InverseProperty("PersonBasePayChangeAmountFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetailPersonBasePayChangeAmountFrequencyCodeNavigations { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();

    [InverseProperty("PersonBasePayFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetailPersonBasePayFrequencyCodeNavigations { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();

    [InverseProperty("AmountChangeFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayDetail> UsysSalaryPlanOtherPayDetails { get; set; } = new List<UsysSalaryPlanOtherPayDetail>();

    [InverseProperty("PersonOtherPayChangeAmountFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetailPersonOtherPayChangeAmountFrequencyCodeNavigations { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();

    [InverseProperty("PersonOtherPayFrequencyCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetailPersonOtherPayFrequencyCodeNavigations { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();
}
