using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitPlanOptionAutoEnroll")]
[Index("BenefitPlanOptionGuid", Name = "AK_tBenefitPlanOptionGUID", IsUnique = true)]
public partial class TBenefitPlanOptionAutoEnroll
{
    [Key]
    [Column("BenefitPlanOptionGUID")]
    public Guid BenefitPlanOptionGuid { get; set; }

    public int? QualifyTime { get; set; }

    [StringLength(15)]
    public string? QualifyTimeUnit { get; set; }

    public bool StartOfMonthFlag { get; set; }

    [StringLength(15)]
    public string? StartBenefitStatusCode { get; set; }

    [Column("BenefitPlanOptionAutoEnrollGUID")]
    public Guid BenefitPlanOptionAutoEnrollGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitPlanOptionAutoEnroll")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("StartBenefitStatusCode")]
    [InverseProperty("TBenefitPlanOptionAutoEnrolls")]
    public virtual TBenefitStatus? StartBenefitStatusCodeNavigation { get; set; }
}
