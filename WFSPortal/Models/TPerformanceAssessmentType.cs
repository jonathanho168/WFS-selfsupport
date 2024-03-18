using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceAssessmentType")]
[Index("PerformanceAssessmentTypeGuid", Name = "RG_tPerformanceAssessmentType", IsUnique = true)]
public partial class TPerformanceAssessmentType
{
    [Key]
    [StringLength(15)]
    public string PerformanceAssessmentTypeCode { get; set; } = null!;

    [Column("PerformanceAssessmentTypeGUID")]
    public Guid PerformanceAssessmentTypeGuid { get; set; }

    public bool UsedForGoalFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool UsedForJobCompetencyFlag { get; set; }

    public string? PerformanceAssessmentTypeDescription { get; set; }

    [InverseProperty("PerformanceAssessmentTypeCodeNavigation")]
    public virtual ICollection<TPerformanceAssessment> TPerformanceAssessments { get; set; } = new List<TPerformanceAssessment>();

    [InverseProperty("PerformanceAssessmentTypeCodeNavigation")]
    public virtual ICollection<TPerformanceQuestion> TPerformanceQuestions { get; set; } = new List<TPerformanceQuestion>();

    [InverseProperty("OverrideAssessmentTypeCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();
}
