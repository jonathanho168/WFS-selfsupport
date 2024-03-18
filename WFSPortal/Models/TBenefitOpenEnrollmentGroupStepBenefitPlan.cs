using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitOpenEnrollmentGroupStepBenefitPlan")]
[Index("BenefitOpenEnrollmentGroupStepGuid", "BenefitPlanCode", Name = "AK_tBenefitOpenEnrollmentGroupStepBenefitPlan_StepPlan", IsUnique = true)]
public partial class TBenefitOpenEnrollmentGroupStepBenefitPlan
{
    [Key]
    [Column("BenefitOpenEnrollmentGroupStepBenefitPlanGUID")]
    public Guid BenefitOpenEnrollmentGroupStepBenefitPlanGuid { get; set; }

    [Column("BenefitOpenEnrollmentGroupStepGUID")]
    public Guid BenefitOpenEnrollmentGroupStepGuid { get; set; }

    public int SortOrder { get; set; }

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupStepGuid")]
    [InverseProperty("TBenefitOpenEnrollmentGroupStepBenefitPlans")]
    public virtual TBenefitOpenEnrollmentGroupStep BenefitOpenEnrollmentGroupStep { get; set; } = null!;

    [ForeignKey("BenefitPlanCode")]
    [InverseProperty("TBenefitOpenEnrollmentGroupStepBenefitPlans")]
    public virtual TBenefitPlan BenefitPlanCodeNavigation { get; set; } = null!;
}
