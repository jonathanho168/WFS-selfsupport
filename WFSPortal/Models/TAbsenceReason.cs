using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceReason")]
[Index("AbsenceReasonGuid", Name = "RG_tAbsenceReason", IsUnique = true)]
public partial class TAbsenceReason
{
    [Key]
    [StringLength(15)]
    public string AbsenceReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string AbsenceAdjustmentReasonCode { get; set; } = null!;

    [Column("AbsenceReasonGUID")]
    public Guid AbsenceReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool MilitaryServiceFlag { get; set; }

    public string? AbsenceReasonDescription { get; set; }

    [Column("HideInESSFlag")]
    public bool HideInEssflag { get; set; }

    public bool IsHolidayReasonFlag { get; set; }

    [ForeignKey("AbsenceAdjustmentReasonCode")]
    [InverseProperty("TAbsenceReasons")]
    public virtual TAbsenceAdjustmentReason AbsenceAdjustmentReasonCodeNavigation { get; set; } = null!;

    [InverseProperty("AbsenceReasonCodeNavigation")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();
}
