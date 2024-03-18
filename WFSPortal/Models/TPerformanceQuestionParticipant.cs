using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionParticipant")]
public partial class TPerformanceQuestionParticipant
{
    [Key]
    [Column("PerformanceQuestionParticipantGUID")]
    public Guid PerformanceQuestionParticipantGuid { get; set; }

    [StringLength(15)]
    public string PerformanceQuestionCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceParticipantTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceParticipantTypeCode")]
    [InverseProperty("TPerformanceQuestionParticipants")]
    public virtual TPerformanceParticipantType PerformanceParticipantTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceQuestionCode")]
    [InverseProperty("TPerformanceQuestionParticipants")]
    public virtual TPerformanceQuestion PerformanceQuestionCodeNavigation { get; set; } = null!;
}
