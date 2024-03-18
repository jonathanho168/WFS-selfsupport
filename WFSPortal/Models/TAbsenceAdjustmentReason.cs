using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceAdjustmentReason")]
[Index("AbsenceAdjustmentReasonGuid", Name = "RG_tAbsenceAdjustmentReason", IsUnique = true)]
public partial class TAbsenceAdjustmentReason
{
    [Key]
    [StringLength(15)]
    public string AbsenceAdjustmentReasonCode { get; set; } = null!;

    [Column("AbsenceAdjustmentReasonGUID")]
    public Guid AbsenceAdjustmentReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? AbsenceAdjustmentReasonDescription { get; set; }

    [InverseProperty("AbsenceAdjustmentReasonCodeNavigation")]
    public virtual ICollection<TAbsenceReason> TAbsenceReasons { get; set; } = new List<TAbsenceReason>();
}
