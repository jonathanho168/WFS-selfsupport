using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobCompetency")]
[Index("JobCode", "CompetencyCode", "PositionCode", Name = "AK_tJobCompetency", IsUnique = true)]
[Index("CompetencyCode", Name = "IX_tJobCompetency_CompetencyCode")]
public partial class TJobCompetency
{
    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    public byte? CompetencyPriority { get; set; }

    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Key]
    [Column("JobCompetencyGUID")]
    public Guid JobCompetencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool IncludeOnPerformanceReviewFlag { get; set; }

    public int? MonthsToComplete { get; set; }

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TJobCompetencies")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TJobCompetencies")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobCompetencies")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ProficiencyCode")]
    [InverseProperty("TJobCompetencies")]
    public virtual TProficiency ProficiencyCodeNavigation { get; set; } = null!;
}
