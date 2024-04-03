using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTimeGroupPeriodOvertime")]
public partial class TPersonTimeGroupPeriodOvertime
{
    [Key]
    [Column("PersonTimeGroupPeriodOvertimeGUID")]
    public Guid PersonTimeGroupPeriodOvertimeGuid { get; set; }

    [Column("PersonTimeGroupPeriodGUID")]
    public Guid PersonTimeGroupPeriodGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string OvertimeType { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CalculatedHours { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? AbsencePlanCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CompTimeMultiplier { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TPersonTimeGroupPeriodOvertimes")]
    public virtual TAbsencePlan? AbsencePlanCodeNavigation { get; set; }

    [ForeignKey("PersonTimeGroupPeriodGuid")]
    [InverseProperty("TPersonTimeGroupPeriodOvertimes")]
    public virtual TPersonTimeGroupPeriod PersonTimeGroupPeriod { get; set; } = null!;

    [ForeignKey("TimeTypeCode")]
    [InverseProperty("TPersonTimeGroupPeriodOvertimes")]
    public virtual TTimeType TimeTypeCodeNavigation { get; set; } = null!;
}
