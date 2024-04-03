using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitPlanTermination")]
[Index("BenefitPlanCode", Name = "AK_tBenefitPlanCode", IsUnique = true)]
public partial class TBenefitPlanTermination
{
    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    public int? QualifyTime { get; set; }

    [StringLength(15)]
    public string? QualifyTimeUnit { get; set; }

    public bool EndOfMonthFlag { get; set; }

    [Key]
    [Column("BenefitPlanTerminationGUID")]
    public Guid BenefitPlanTerminationGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitPlanCode")]
    [InverseProperty("TBenefitPlanTermination")]
    public virtual TBenefitPlan BenefitPlanCodeNavigation { get; set; } = null!;
}
