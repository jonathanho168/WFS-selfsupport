using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonOvertimeHist")]
[Index("PersonGuid", "PositionCode", "PersonOvertimeStartDate", Name = "AK_tPersonOvertimeHist", IsUnique = true)]
public partial class TPersonOvertimeHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonOvertimeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonOvertimeEndDate { get; set; }

    [StringLength(15)]
    public string? ProjectCode { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public bool PrimaryPosition { get; set; }

    [StringLength(15)]
    public string? TimeGroupCode { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HoursWorked { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? RevisedHoursWorked { get; set; }

    [Column("OTHours", TypeName = "decimal(19, 2)")]
    public decimal? Othours { get; set; }

    [Column("RevisedOTHours", TypeName = "decimal(19, 2)")]
    public decimal? RevisedOthours { get; set; }

    [Column("OTRate", TypeName = "decimal(19, 2)")]
    public decimal? Otrate { get; set; }

    [Column("RevisedOTRate", TypeName = "decimal(19, 2)")]
    public decimal? RevisedOtrate { get; set; }

    [StringLength(15)]
    public string? TempDepartmentCode { get; set; }

    [Column("OTEarnings", TypeName = "decimal(19, 2)")]
    public decimal? Otearnings { get; set; }

    [Column("RevisedOTEarnings", TypeName = "decimal(19, 2)")]
    public decimal? RevisedOtearnings { get; set; }

    [Column("StraightTimeOTEarnings", TypeName = "decimal(19, 2)")]
    public decimal? StraightTimeOtearnings { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? RevisedStraightTimeEarnings { get; set; }

    public string? Comments { get; set; }

    public bool PersonOvertimeCurrentFlag { get; set; }

    [Key]
    [Column("PersonOvertimeGUID")]
    public Guid PersonOvertimeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonOvertimeHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonOvertimeHists")]
    public virtual TPosition? PositionCodeNavigation { get; set; }

    [ForeignKey("ProjectCode")]
    [InverseProperty("TPersonOvertimeHists")]
    public virtual TProject? ProjectCodeNavigation { get; set; }

    [ForeignKey("TempDepartmentCode")]
    [InverseProperty("TPersonOvertimeHists")]
    public virtual TDepartment? TempDepartmentCodeNavigation { get; set; }

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("TPersonOvertimeHists")]
    public virtual TTimeGroup? TimeGroupCodeNavigation { get; set; }
}
