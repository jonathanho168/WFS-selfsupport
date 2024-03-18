using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonPerformanceQuestionAnswerJournal")]
public partial class TPersonPerformanceQuestionAnswerJournal
{
    [Key]
    public Guid PersonPerformanceQuestionAnswerJournalGuid { get; set; }

    public Guid PerformanceQuestionAnswerGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JournalDate { get; set; }

    [StringLength(15)]
    public string? PerformanceQuestionJournalTypeCode { get; set; }

    public string? Comments { get; set; }

    public byte[]? JournalAttachment { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceQuestionAnswerGuid")]
    [InverseProperty("TPersonPerformanceQuestionAnswerJournals")]
    public virtual TPersonPerformanceQuestionAnswer PerformanceQuestionAnswer { get; set; } = null!;

    [ForeignKey("PerformanceQuestionJournalTypeCode")]
    [InverseProperty("TPersonPerformanceQuestionAnswerJournals")]
    public virtual TPerformanceQuestionJournalType? PerformanceQuestionJournalTypeCodeNavigation { get; set; }
}
