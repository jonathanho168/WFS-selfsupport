using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceHist")]
public partial class TPersonPerformanceHist
{
    [Key]
    [Column("PersonPerformanceGUID")]
    public Guid PersonPerformanceGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonPerformanceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonPerformanceEndDate { get; set; }

    [Column("RatedByPersonGUID")]
    public Guid? RatedByPersonGuid { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScheduledReviewDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PerformedDate { get; set; }

    [StringLength(15)]
    public string PerformanceRatingCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceReviewTypeCode { get; set; } = null!;

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    public string? Comments { get; set; }

    public bool PersonPerformanceCurrentFlag { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? CalculatedScore { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FinalScore { get; set; }

    public string? ConfidentialComments { get; set; }

    public bool SubmittedFlag { get; set; }

    public bool CompletedFlag { get; set; }

    public string? EmployeeGoalsComments { get; set; }

    public string? EmployeeComments { get; set; }

    public bool EmployeeRespondsBeforeReviewerFlag { get; set; }

    public bool EmployeeRespondsAfterReviewerFlag { get; set; }

    public bool SentToEmployeeFlag { get; set; }

    public bool EmployeeCompletedFlag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? EmployeeCalculatedScore { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? EmployeeFinalScore { get; set; }

    public bool EmployeeAnswersRequiredFlag { get; set; }

    public int RowVersion { get; set; }

    public bool ParticipantsCompletedFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OtherParticipantDueDate { get; set; }

    public bool ScoredFlag { get; set; }

    public byte[]? Attachment { get; set; }

    public bool? GeneratedWithGoals { get; set; }

    public bool? GeneratedWithCompetencies { get; set; }

    public bool AllowEmployeeToSeeAttachmentFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteAllParticipantReviewsDate { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TPersonPerformanceHists")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceRatingCode")]
    [InverseProperty("TPersonPerformanceHists")]
    public virtual TPerformanceRating PerformanceRatingCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceReviewTypeCode")]
    [InverseProperty("TPersonPerformanceHists")]
    public virtual TPerformanceReviewType PerformanceReviewTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonPerformanceHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonPerformanceHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("RatedByPersonGuid")]
    [InverseProperty("TPersonPerformanceHistRatedByPeople")]
    public virtual TPerson? RatedByPerson { get; set; }

    [ForeignKey("SupervisorPersonGuid")]
    [InverseProperty("TPersonPerformanceHistSupervisorPeople")]
    public virtual TPerson? SupervisorPerson { get; set; }

    [InverseProperty("PersonPerformance")]
    public virtual ICollection<TPersonPerformanceOverallComment> TPersonPerformanceOverallComments { get; set; } = new List<TPersonPerformanceOverallComment>();

    [InverseProperty("PersonPerformance")]
    public virtual ICollection<TPersonPerformanceParticipant> TPersonPerformanceParticipants { get; set; } = new List<TPersonPerformanceParticipant>();

    [InverseProperty("PersonPerformance")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();
}
