using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsenceHist")]
[Index("PersonAbsencePlanGuid", "AbsenceTransactionTypeCode", "PersonAbsenceStartDate", Name = "AK_tPersonAbsenceHist", IsUnique = true)]
[Index("PersonLeaveRequestGuid", "MilitaryCaregiverFlag", Name = "WFS_tPersonAbsenceHist_PersonLeaveRequestGUID_MilitaryCaregiverFlag")]
public partial class TPersonAbsenceHist
{
    [Column(TypeName = "datetime")]
    public DateTime PersonAbsenceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonAbsenceEndDate { get; set; }

    [StringLength(15)]
    public string AbsenceReasonCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AbsenceDuration { get; set; }

    public bool ExcusedFlag { get; set; }

    [Column("FMLAFlag")]
    public bool Fmlaflag { get; set; }

    public bool PaidFlag { get; set; }

    public string? Comments { get; set; }

    public bool PersonAbsenceCurrentFlag { get; set; }

    [Key]
    [Column("PersonAbsenceGUID")]
    public Guid PersonAbsenceGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [Column("PersonAbsencePlanGUID")]
    public Guid PersonAbsencePlanGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CurrentBalanceDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CurrentBalance { get; set; }

    [StringLength(15)]
    public string AbsenceTransactionTypeCode { get; set; } = null!;

    [Column("PersonLeaveRequestGUID")]
    public Guid? PersonLeaveRequestGuid { get; set; }

    public bool MilitaryCaregiverFlag { get; set; }

    [StringLength(15)]
    public string? LeaveTypeCode { get; set; }

    public bool ExcludeFromExportFlag { get; set; }

    [ForeignKey("AbsenceReasonCode")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual TAbsenceReason AbsenceReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsenceTransactionTypeCode")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual UsysAbsenceTransactionType AbsenceTransactionTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("LeaveTypeCode")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual TLeaveType? LeaveTypeCodeNavigation { get; set; }

    [ForeignKey("PersonAbsencePlanGuid")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual TPersonAbsencePlan PersonAbsencePlan { get; set; } = null!;

    [ForeignKey("PersonLeaveRequestGuid")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual TPersonLeaveRequest? PersonLeaveRequest { get; set; }

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonAbsenceHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonAbsence")]
    public virtual ICollection<TPersonAbsenceHistFile> TPersonAbsenceHistFiles { get; set; } = new List<TPersonAbsenceHistFile>();

    [InverseProperty("PersonAbsence")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();
}
