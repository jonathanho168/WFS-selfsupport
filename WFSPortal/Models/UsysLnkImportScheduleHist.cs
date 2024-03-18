using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportScheduleHist")]
[Index("ScheduleImportName", Name = "AK_USysLnkImportScheduleHist", IsUnique = true)]
public partial class UsysLnkImportScheduleHist
{
    [Column(TypeName = "datetime")]
    public DateTime ImportScheduleStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ImportScheduleEndDate { get; set; }

    [StringLength(15)]
    public string ImportGroupCode { get; set; } = null!;

    [StringLength(40)]
    public string ScheduleImportName { get; set; } = null!;

    public bool ScheduleEnabledFlag { get; set; }

    public bool ImportScheduleCurrentFlag { get; set; }

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

    public int? FrequencyMonthylRecursNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DailyFrequencyTime { get; set; }

    public bool CommitAfterProcessFlag { get; set; }

    [Key]
    [Column("LnkImportScheduleGUID")]
    public Guid LnkImportScheduleGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(255)]
    public string? NotificationEmailAddress { get; set; }

    public bool EmailNotificationFlag { get; set; }

    [ForeignKey("ImportGroupCode")]
    [InverseProperty("UsysLnkImportScheduleHists")]
    public virtual UsysLnkImportGroup ImportGroupCodeNavigation { get; set; } = null!;
}
