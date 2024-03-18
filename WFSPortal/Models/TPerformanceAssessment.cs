using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceAssessment")]
[Index("PerformanceAssessmentGuid", Name = "RG_tPerformanceAssessment", IsUnique = true)]
public partial class TPerformanceAssessment
{
    [Key]
    [StringLength(15)]
    public string PerformanceAssessmentCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceAssessmentTypeCode { get; set; } = null!;

    [Column("PerformanceAssessmentGUID")]
    public Guid PerformanceAssessmentGuid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Score { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SuggestedComments { get; set; }

    public string? PerformanceAssessmentDescription { get; set; }

    [ForeignKey("PerformanceAssessmentTypeCode")]
    [InverseProperty("TPerformanceAssessments")]
    public virtual TPerformanceAssessmentType PerformanceAssessmentTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("PerformanceAssessmentCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestionAnswer> TPersonPerformanceQuestionAnswers { get; set; } = new List<TPersonPerformanceQuestionAnswer>();
}
