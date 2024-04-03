using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestion")]
[Index("PerformanceQuestionGuid", Name = "RG_tPerformanceQuestion", IsUnique = true)]
public partial class TPerformanceQuestion
{
    [Key]
    [StringLength(15)]
    public string PerformanceQuestionCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceQuestionGroupCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceAssessmentTypeCode { get; set; } = null!;

    public string? QuestionText { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? QuestionWeight { get; set; }

    public bool WeightOverridableFlag { get; set; }

    public bool CommentRequiredFlag { get; set; }

    public bool ScoredFlag { get; set; }

    public bool AllEmployeesFlag { get; set; }

    public bool AllSupervisorsFlag { get; set; }

    [Column("PerformanceQuestionGUID")]
    public Guid PerformanceQuestionGuid { get; set; }

    public bool EmployeeCommentRequiredFlag { get; set; }

    public int RowVersion { get; set; }

    public bool OtherParticipantCommentRequiredFlag { get; set; }

    public bool AllReviewTypesFlag { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string? RuleSetCode { get; set; }

    public bool? AllParticipantTypeFlag { get; set; }

    public int SortOrder { get; set; }

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("TPerformanceQuestions")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceAssessmentTypeCode")]
    [InverseProperty("TPerformanceQuestions")]
    public virtual TPerformanceAssessmentType PerformanceAssessmentTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceQuestionGroupCode")]
    [InverseProperty("TPerformanceQuestions")]
    public virtual TPerformanceQuestionGroup PerformanceQuestionGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("RuleSetCode")]
    [InverseProperty("TPerformanceQuestions")]
    public virtual UsysRuleSet? RuleSetCodeNavigation { get; set; }

    [InverseProperty("PerformanceQuestionCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionJob> TPerformanceQuestionJobs { get; set; } = new List<TPerformanceQuestionJob>();

    [InverseProperty("PerformanceQuestionCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionParticipant> TPerformanceQuestionParticipants { get; set; } = new List<TPerformanceQuestionParticipant>();

    [InverseProperty("PerformanceQuestionCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionPosition> TPerformanceQuestionPositions { get; set; } = new List<TPerformanceQuestionPosition>();

    [InverseProperty("PerformanceQuestionCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionReviewType> TPerformanceQuestionReviewTypes { get; set; } = new List<TPerformanceQuestionReviewType>();

    [InverseProperty("PerformanceQuestionCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();
}
