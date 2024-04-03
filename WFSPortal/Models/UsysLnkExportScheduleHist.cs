using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportScheduleHist")]
public partial class UsysLnkExportScheduleHist
{
    [Key]
    [Column("LnkExportScheduleGUID")]
    public Guid LnkExportScheduleGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LnkExportScheduleStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LnkExportScheduleEndDate { get; set; }

    [Column("LnkExportGroupGUID")]
    public Guid LnkExportGroupGuid { get; set; }

    [StringLength(80)]
    public string ScheduleExportName { get; set; } = null!;

    public bool ScheduleEnabledFlag { get; set; }

    public bool LnkExportScheduleCurrentFlag { get; set; }

    [StringLength(5)]
    public string FrequencyOccursUnit { get; set; } = null!;

    [StringLength(5)]
    public string? FrequencyRecursUnit { get; set; }

    public int? FrequencyRecursNumber { get; set; }

    public int? FrequencyRecursDay { get; set; }

    public int? FrequencyMonthlyDayOccursNumber { get; set; }

    public int? FrequencyMonthlyMonthOccursNumber { get; set; }

    [StringLength(5)]
    public string? FrequencyMonthlyWeek { get; set; }

    [StringLength(5)]
    public string? FrequencyMonthlyDay { get; set; }

    public int? FrequencyMonthlyRecursNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DailyFrequencyTime { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LnkExportGroupGuid")]
    [InverseProperty("UsysLnkExportScheduleHists")]
    public virtual UsysLnkExportGroup LnkExportGroup { get; set; } = null!;
}
