using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitOpenEnrollmentGroupStep")]
public partial class TBenefitOpenEnrollmentGroupStep
{
    [Key]
    [Column("BenefitOpenEnrollmentGroupStepGUID")]
    public Guid BenefitOpenEnrollmentGroupStepGuid { get; set; }

    public int StepNumber { get; set; }

    public string? StepDescription { get; set; }

    [StringLength(15)]
    public string BenefitOpenEnrollmentGroupCode { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitOpenEnrollmentGroupCode")]
    [InverseProperty("TBenefitOpenEnrollmentGroupSteps")]
    public virtual TBenefitOpenEnrollmentGroup BenefitOpenEnrollmentGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("BenefitOpenEnrollmentGroupStep")]
    public virtual ICollection<TBenefitOpenEnrollmentGroupStepBenefitPlan> TBenefitOpenEnrollmentGroupStepBenefitPlans { get; set; } = new List<TBenefitOpenEnrollmentGroupStepBenefitPlan>();
}
