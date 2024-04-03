using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceQuestionAnswer")]
public partial class TPersonPerformanceQuestionAnswer
{
    [Key]
    [Column("PerformanceQuestionAnswerGUID")]
    public Guid PerformanceQuestionAnswerGuid { get; set; }

    [Column("PerformanceQuestionGUID")]
    public Guid PerformanceQuestionGuid { get; set; }

    [StringLength(15)]
    public string PerformanceAssessmentCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? QuestionScore { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonPerformanceParticipantGUID")]
    public Guid PersonPerformanceParticipantGuid { get; set; }

    [StringLength(15)]
    public string? GoalProficiencyCode { get; set; }

    [ForeignKey("GoalProficiencyCode")]
    [InverseProperty("TPersonPerformanceQuestionAnswers")]
    public virtual TProficiency? GoalProficiencyCodeNavigation { get; set; }

    [ForeignKey("PerformanceAssessmentCode")]
    [InverseProperty("TPersonPerformanceQuestionAnswers")]
    public virtual TPerformanceAssessment PerformanceAssessmentCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceQuestionGuid")]
    [InverseProperty("TPersonPerformanceQuestionAnswers")]
    public virtual TPersonPerformanceQuestion PerformanceQuestion { get; set; } = null!;

    [ForeignKey("PersonPerformanceParticipantGuid")]
    [InverseProperty("TPersonPerformanceQuestionAnswers")]
    public virtual TPersonPerformanceParticipant PersonPerformanceParticipant { get; set; } = null!;

    [InverseProperty("PerformanceQuestionAnswer")]
    public virtual ICollection<TPersonPerformanceQuestionAnswerJournal> TPersonPerformanceQuestionAnswerJournals { get; set; } = new List<TPersonPerformanceQuestionAnswerJournal>();
}
