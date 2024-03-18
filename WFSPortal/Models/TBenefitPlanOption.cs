using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitPlanOption")]
[Index("BenefitPlanCode", "BenefitPlanOptionCode", Name = "AK_tBenefitPlanOptionCode", IsUnique = true)]
public partial class TBenefitPlanOption
{
    [StringLength(15)]
    public string BenefitPlanOptionCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [Key]
    [Column("BenefitPlanOptionGUID")]
    public Guid BenefitPlanOptionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public int SortOrder { get; set; }

    public string? BenefitPlanOptionDescription { get; set; }

    [ForeignKey("BenefitPlanCode")]
    [InverseProperty("TBenefitPlanOptions")]
    public virtual TBenefitPlan BenefitPlanCodeNavigation { get; set; } = null!;

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TBenefitEligibilityParameterHist> TBenefitEligibilityParameterHists { get; set; } = new List<TBenefitEligibilityParameterHist>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TBenefitHist> TBenefitHists { get; set; } = new List<TBenefitHist>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TBenefitOpenEnrollmentGroupPlanOption> TBenefitOpenEnrollmentGroupPlanOptions { get; set; } = new List<TBenefitOpenEnrollmentGroupPlanOption>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TBenefitParametersHist> TBenefitParametersHists { get; set; } = new List<TBenefitParametersHist>();

    [InverseProperty("BenefitPlanOption")]
    public virtual TBenefitPlanOptionAutoEnroll? TBenefitPlanOptionAutoEnroll { get; set; }

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TBenefitRangeHist> TBenefitRangeHists { get; set; } = new List<TBenefitRangeHist>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TPersonBenefitHist> TPersonBenefitHists { get; set; } = new List<TPersonBenefitHist>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TPersonBenefitOptOut> TPersonBenefitOptOuts { get; set; } = new List<TPersonBenefitOptOut>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<TPersonFutureEnrollment> TPersonFutureEnrollments { get; set; } = new List<TPersonFutureEnrollment>();

    [InverseProperty("BenefitPlanOption")]
    public virtual ICollection<UsysLnkRollupBenefit> UsysLnkRollupBenefits { get; set; } = new List<UsysLnkRollupBenefit>();
}
