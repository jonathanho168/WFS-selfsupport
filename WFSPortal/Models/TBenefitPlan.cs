using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitPlan")]
[Index("BenefitTypeCode", Name = "IX_tBenefitPlan_BenefitTypeCode")]
[Index("BenefitPlanGuid", Name = "RG_tBenefitPlan", IsUnique = true)]
public partial class TBenefitPlan
{
    [Key]
    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitTypeCode { get; set; } = null!;

    [Column("BenefitPlanGUID")]
    public Guid BenefitPlanGuid { get; set; }

    public bool FlexCreditFlag { get; set; }

    public bool UsesTobaccoUserFlag { get; set; }

    public bool UsesNumericValuesFlag { get; set; }

    public bool UsesTextValuesFlag { get; set; }

    [Column("DocumentationURL")]
    [StringLength(200)]
    public string? DocumentationUrl { get; set; }

    [StringLength(15)]
    public string BenefitPlanAdministratorCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool MultipleOptionEnrollmentFlag { get; set; }

    public bool OpenEnrollmentCopyBeneficiaryFlag { get; set; }

    public bool BenefitOptionChangeOnlyFlag { get; set; }

    [Column("ExcludeFromESSFlag")]
    public bool ExcludeFromEssflag { get; set; }

    public string? BenefitPlanDescription { get; set; }

    public string? Notes { get; set; }

    [Column("AllowESSEditContributionFlag")]
    public bool AllowEsseditContributionFlag { get; set; }

    [ForeignKey("BenefitPlanAdministratorCode")]
    [InverseProperty("TBenefitPlans")]
    public virtual TBenefitPlanAdministrator BenefitPlanAdministratorCodeNavigation { get; set; } = null!;

    [ForeignKey("BenefitTypeCode")]
    [InverseProperty("TBenefitPlans")]
    public virtual TBenefitType BenefitTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("BenefitPlanCodeNavigation")]
    public virtual ICollection<TBenefitCarrierHist> TBenefitCarrierHists { get; set; } = new List<TBenefitCarrierHist>();

    [InverseProperty("BenefitPlanCodeNavigation")]
    public virtual ICollection<TBenefitOpenEnrollmentGroupStepBenefitPlan> TBenefitOpenEnrollmentGroupStepBenefitPlans { get; set; } = new List<TBenefitOpenEnrollmentGroupStepBenefitPlan>();

    [InverseProperty("CoverageMaxCompareToPlanCodeNavigation")]
    public virtual ICollection<TBenefitParametersHist> TBenefitParametersHists { get; set; } = new List<TBenefitParametersHist>();

    [InverseProperty("BenefitPlanCodeNavigation")]
    public virtual ICollection<TBenefitPlanOption> TBenefitPlanOptions { get; set; } = new List<TBenefitPlanOption>();

    [InverseProperty("BenefitPlanCodeNavigation")]
    public virtual TBenefitPlanTermination? TBenefitPlanTermination { get; set; }
}
