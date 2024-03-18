using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionJournalType")]
[Index("PerformanceQuestionJournalTypeGuid", Name = "RG_tPerformanceQuestionJournalType", IsUnique = true)]
public partial class TPerformanceQuestionJournalType
{
    [Key]
    [StringLength(15)]
    public string PerformanceQuestionJournalTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public Guid PerformanceQuestionJournalTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? PerformanceQuestionJournalTypeDescription { get; set; }

    [InverseProperty("PerformanceQuestionJournalTypeCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestionAnswerJournal> TPersonPerformanceQuestionAnswerJournals { get; set; } = new List<TPersonPerformanceQuestionAnswerJournal>();
}
