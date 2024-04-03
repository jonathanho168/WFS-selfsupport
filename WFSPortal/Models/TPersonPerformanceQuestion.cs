using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceQuestion")]
public partial class TPersonPerformanceQuestion
{
    [Key]
    [Column("PerformanceQuestionGUID")]
    public Guid PerformanceQuestionGuid { get; set; }

    [Column("PersonPerformanceGUID")]
    public Guid PersonPerformanceGuid { get; set; }

    [StringLength(15)]
    public string? PerformanceQuestionCode { get; set; }

    [StringLength(15)]
    public string PerformanceQuestionGroupCode { get; set; } = null!;

    public string? QuestionText { get; set; }

    public bool ScoredFlag { get; set; }

    public bool WeightOverridableFlag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal OriginalQuestionWeight { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? OverrideQuestionWeight { get; set; }

    public bool CommentRequiredFlag { get; set; }

    public int SortOrder { get; set; }

    public bool EmployeeCommentRequiredFlag { get; set; }

    public int RowVersion { get; set; }

    public bool OtherParticipantCommentRequiredFlag { get; set; }

    public byte[]? Attachment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GoalAchievedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GoalClosedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GoalDeferredUntilDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? GoalActualAmount { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? GoalCompletionPercentage { get; set; }

    [StringLength(15)]
    public string? CompetencyCode { get; set; }

    [StringLength(15)]
    public string? OverrideAssessmentTypeCode { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    [StringLength(15)]
    public string? CertificationCode { get; set; }

    [StringLength(15)]
    public string? CourseCode { get; set; }

    [StringLength(15)]
    public string? LanguageCode { get; set; }

    [StringLength(15)]
    public string? TrainingProgramCode { get; set; }

    [StringLength(15)]
    public string QuestionLanguageCode { get; set; } = null!;

    public bool AllowEmployeeToSeeAttachmentFlag { get; set; }

    [ForeignKey("CertificationCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TCertification? CertificationCodeNavigation { get; set; }

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TCompetency? CompetencyCodeNavigation { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TCourse? CourseCodeNavigation { get; set; }

    [ForeignKey("LanguageCode")]
    [InverseProperty("TPersonPerformanceQuestionLanguageCodeNavigations")]
    public virtual TLanguage? LanguageCodeNavigation { get; set; }

    [ForeignKey("OverrideAssessmentTypeCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TPerformanceAssessmentType? OverrideAssessmentTypeCodeNavigation { get; set; }

    [ForeignKey("PerformanceQuestionCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TPerformanceQuestion? PerformanceQuestionCodeNavigation { get; set; }

    [ForeignKey("PerformanceQuestionGroupCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TPerformanceQuestionGroup PerformanceQuestionGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("PersonPerformanceGuid")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TPersonPerformanceHist PersonPerformance { get; set; } = null!;

    [ForeignKey("QuestionLanguageCode")]
    [InverseProperty("TPersonPerformanceQuestionQuestionLanguageCodeNavigations")]
    public virtual TLanguage QuestionLanguageCodeNavigation { get; set; } = null!;

    [InverseProperty("PerformanceQuestion")]
    public virtual ICollection<TPersonPerformanceQuestionAnswer> TPersonPerformanceQuestionAnswers { get; set; } = new List<TPersonPerformanceQuestionAnswer>();

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TPersonPerformanceQuestions")]
    public virtual TTrainingProgram? TrainingProgramCodeNavigation { get; set; }
}
