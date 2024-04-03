using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitHist")]
public partial class TBenefitHist
{
    [Column(TypeName = "datetime")]
    public DateTime BenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitEndDate { get; set; }

    [StringLength(15)]
    public string BenefitFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitCurrencyCode { get; set; } = null!;

    public bool DependentCoverageFlag { get; set; }

    public byte? DependentMaximumAge { get; set; }

    [StringLength(15)]
    public string EmployeeContributionFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string EmployerContributionFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string FlexCreditFrequencyCode { get; set; } = null!;

    public bool HealthPlanFlag { get; set; }

    [StringLength(15)]
    public string ImputedFrequencyCode { get; set; } = null!;

    public byte? ParticipantMaximumAge { get; set; }

    [StringLength(15)]
    public string PremiumFrequencyCode { get; set; } = null!;

    [StringLength(128)]
    public string? EligibilityFunction { get; set; }

    [StringLength(128)]
    public string? ContributionFunction { get; set; }

    [StringLength(1)]
    public string? TaxMethod { get; set; }

    public int? WaitingPeriod { get; set; }

    [StringLength(15)]
    public string WaitingPeriodFrequencyCode { get; set; } = null!;

    public bool BenefitCurrentFlag { get; set; }

    [Key]
    [Column("BenefitHistGUID")]
    public Guid BenefitHistGuid { get; set; }

    [StringLength(15)]
    public string DependentTypeCode { get; set; } = null!;

    public bool AllowsBeneficiariesFlag { get; set; }

    public bool AllowsClaimsFlag { get; set; }

    [StringLength(30)]
    public string? NumericValue1Label { get; set; }

    [StringLength(30)]
    public string? NumericValue2Label { get; set; }

    [StringLength(30)]
    public string? NumericValue3Label { get; set; }

    [StringLength(30)]
    public string? TextValue1Label { get; set; }

    [StringLength(30)]
    public string? TextValue2Label { get; set; }

    [StringLength(30)]
    public string? TextValue3Label { get; set; }

    public bool RequiredReenrollFlag { get; set; }

    public bool PrimaryCarePhysicianFlag { get; set; }

    [StringLength(15)]
    public string PhysicianTypeCode { get; set; } = null!;

    public bool UsesFixedAgeFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    public bool PercentBasedCoverageFlag { get; set; }

    public byte? MaximumDependents { get; set; }

    public byte? MinimumDependents { get; set; }

    [StringLength(128)]
    public string? EligibilityProcedure { get; set; }

    [StringLength(128)]
    public string? ContributionProcedure { get; set; }

    public string? BenefitDescription { get; set; }

    [StringLength(15)]
    public string Dependent834TypeCode { get; set; } = null!;

    public bool WaiveCoverageFlag { get; set; }

    public byte[]? BenefitOptionDocument { get; set; }

    public bool AutoEnrollmentFlag { get; set; }

    public int? AutoEnrollmentEffectiveFromHireTime { get; set; }

    [StringLength(15)]
    public string AutoEnrollmentEffectiveFromHireFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string AutoEnrollmentStartStatusCode { get; set; } = null!;

    public bool EnrollFirstofMonthFollowingFlag { get; set; }

    public bool OptOutEnrollmentFlag { get; set; }

    public bool AutoEnrollmentActiveFlag { get; set; }

    [ForeignKey("AutoEnrollmentEffectiveFromHireFrequencyCode")]
    [InverseProperty("TBenefitHistAutoEnrollmentEffectiveFromHireFrequencyCodeNavigations")]
    public virtual TFrequency AutoEnrollmentEffectiveFromHireFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("AutoEnrollmentStartStatusCode")]
    [InverseProperty("TBenefitHists")]
    public virtual TBenefitStatus AutoEnrollmentStartStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitCurrencyCode")]
    [InverseProperty("TBenefitHists")]
    public virtual TCurrency BenefitCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitFrequencyCode")]
    [InverseProperty("TBenefitHistBenefitFrequencyCodeNavigations")]
    public virtual TFrequency BenefitFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitHists")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("Dependent834TypeCode")]
    [InverseProperty("TBenefitHists")]
    public virtual TDependent834Type Dependent834TypeCodeNavigation { get; set; } = null!;

    [ForeignKey("DependentTypeCode")]
    [InverseProperty("TBenefitHists")]
    public virtual TDependentType DependentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployeeContributionFrequencyCode")]
    [InverseProperty("TBenefitHistEmployeeContributionFrequencyCodeNavigations")]
    public virtual TFrequency EmployeeContributionFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployerContributionFrequencyCode")]
    [InverseProperty("TBenefitHistEmployerContributionFrequencyCodeNavigations")]
    public virtual TFrequency EmployerContributionFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("FlexCreditFrequencyCode")]
    [InverseProperty("TBenefitHistFlexCreditFrequencyCodeNavigations")]
    public virtual TFrequency FlexCreditFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ImputedFrequencyCode")]
    [InverseProperty("TBenefitHistImputedFrequencyCodeNavigations")]
    public virtual TFrequency ImputedFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PhysicianTypeCode")]
    [InverseProperty("TBenefitHists")]
    public virtual TPhysicianType PhysicianTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PremiumFrequencyCode")]
    [InverseProperty("TBenefitHistPremiumFrequencyCodeNavigations")]
    public virtual TFrequency PremiumFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WaitingPeriodFrequencyCode")]
    [InverseProperty("TBenefitHistWaitingPeriodFrequencyCodeNavigations")]
    public virtual TFrequency WaitingPeriodFrequencyCodeNavigation { get; set; } = null!;
}
