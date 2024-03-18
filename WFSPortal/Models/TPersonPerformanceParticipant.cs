using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceParticipant")]
public partial class TPersonPerformanceParticipant
{
    [Key]
    [Column("PersonPerformanceParticipantGUID")]
    public Guid PersonPerformanceParticipantGuid { get; set; }

    [Column("PersonPerformanceGUID")]
    public Guid PersonPerformanceGuid { get; set; }

    [StringLength(15)]
    public string PerformanceParticipantTypeCode { get; set; } = null!;

    [Column("ParticipantPersonGUID")]
    public Guid? ParticipantPersonGuid { get; set; }

    [Column("PerformanceParticipantGUID")]
    public Guid? PerformanceParticipantGuid { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? FinalScore { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? CalculatedScore { get; set; }

    public bool CompletedFlag { get; set; }

    public bool ScoredFlag { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmitToReviewerDate { get; set; }

    [ForeignKey("ParticipantPersonGuid")]
    [InverseProperty("TPersonPerformanceParticipants")]
    public virtual TPerson? ParticipantPerson { get; set; }

    [ForeignKey("PerformanceParticipantGuid")]
    [InverseProperty("TPersonPerformanceParticipants")]
    public virtual TPerformanceParticipant? PerformanceParticipant { get; set; }

    [ForeignKey("PerformanceParticipantTypeCode")]
    [InverseProperty("TPersonPerformanceParticipants")]
    public virtual TPerformanceParticipantType PerformanceParticipantTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonPerformanceGuid")]
    [InverseProperty("TPersonPerformanceParticipants")]
    public virtual TPersonPerformanceHist PersonPerformance { get; set; } = null!;

    [InverseProperty("PersonPerformanceParticipant")]
    public virtual ICollection<TPersonPerformanceQuestionAnswer> TPersonPerformanceQuestionAnswers { get; set; } = new List<TPersonPerformanceQuestionAnswer>();
}
