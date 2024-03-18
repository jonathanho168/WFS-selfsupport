using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceParticipantType")]
[Index("PerformanceParticipantTypeGuid", Name = "RG_tPerformanceParticipantType", IsUnique = true)]
public partial class TPerformanceParticipantType
{
    [Key]
    [StringLength(15)]
    public string PerformanceParticipantTypeCode { get; set; } = null!;

    [Column("PerformanceParticipantTypeGUID")]
    public Guid PerformanceParticipantTypeGuid { get; set; }

    public bool EmployeeFlag { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string PerformanceParticipantRuleTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool ReviewerParticipantFlag { get; set; }

    public bool EmployeeOtherParticipantFlag { get; set; }

    public string? PerformanceParticipantTypeDescription { get; set; }

    [ForeignKey("PerformanceParticipantRuleTypeCode")]
    [InverseProperty("TPerformanceParticipantTypes")]
    public virtual TPerformanceParticipantRuleType PerformanceParticipantRuleTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("PerformanceParticipantTypeCodeNavigation")]
    public virtual ICollection<TPerformanceParticipant> TPerformanceParticipants { get; set; } = new List<TPerformanceParticipant>();

    [InverseProperty("PerformanceParticipantTypeCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionParticipant> TPerformanceQuestionParticipants { get; set; } = new List<TPerformanceQuestionParticipant>();

    [InverseProperty("PerformanceParticipantTypeCodeNavigation")]
    public virtual ICollection<TPersonPerformanceOverallComment> TPersonPerformanceOverallComments { get; set; } = new List<TPersonPerformanceOverallComment>();

    [InverseProperty("PerformanceParticipantTypeCodeNavigation")]
    public virtual ICollection<TPersonPerformanceParticipant> TPersonPerformanceParticipants { get; set; } = new List<TPersonPerformanceParticipant>();
}
