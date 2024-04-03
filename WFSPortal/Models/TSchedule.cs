using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSchedule")]
[Index("ScheduleGuid", Name = "RG_tSchedule", IsUnique = true)]
public partial class TSchedule
{
    [Key]
    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;

    [StringLength(15)]
    public string ScheduleTypeCode { get; set; } = null!;

    [Column("ScheduleGUID")]
    public Guid ScheduleGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduleStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduleEndTime { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal SundayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal MondayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TuesdayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal WednesdayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal ThursdayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal FridayNumberOfHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal SaturdayNumberOfHours { get; set; }

    public bool AbsenceEligibilityFullTimeFlag { get; set; }

    public string? ScheduleDescription { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ScheduleNormalHoursPerDay { get; set; }

    [ForeignKey("ScheduleTypeCode")]
    [InverseProperty("TSchedules")]
    public virtual TScheduleType ScheduleTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("ScheduleCodeNavigation")]
    public virtual ICollection<TFrequencyConversion> TFrequencyConversions { get; set; } = new List<TFrequencyConversion>();

    [InverseProperty("ScheduleCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHists { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("OtscheduleNavigation")]
    public virtual ICollection<TTimeGroup> TTimeGroups { get; set; } = new List<TTimeGroup>();
}
