using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceParticipantRuleType")]
[Index("PerformanceParticipantRuleTypeGuid", Name = "RG_tPerformanceParticipantRuleType", IsUnique = true)]
public partial class TPerformanceParticipantRuleType
{
    [Key]
    [StringLength(15)]
    public string PerformanceParticipantRuleTypeCode { get; set; } = null!;

    [Column("PerformanceParticipantRuleTypeGUID")]
    public Guid PerformanceParticipantRuleTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string? ParticipantRuleFunction { get; set; }

    public string? PerformanceParticipantRuleTypeDescription { get; set; }

    [InverseProperty("PerformanceParticipantRuleTypeCodeNavigation")]
    public virtual ICollection<TPerformanceParticipantType> TPerformanceParticipantTypes { get; set; } = new List<TPerformanceParticipantType>();
}
