using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAlertSchedule")]
public partial class UsysAlertSchedule
{
    [Key]
    [Column("AlertScheduleGUID")]
    public Guid AlertScheduleGuid { get; set; }

    public int TimeInterval { get; set; }

    [StringLength(15)]
    public string DayMonthCode { get; set; } = null!;

    [StringLength(15)]
    public string BeforeAfterCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [Column("AlertGUID")]
    public Guid AlertGuid { get; set; }

    [ForeignKey("AlertGuid")]
    [InverseProperty("UsysAlertSchedules")]
    public virtual UsysAlert Alert { get; set; } = null!;

    [InverseProperty("AlertSchedule")]
    public virtual ICollection<UsysAlertInstance> UsysAlertInstances { get; set; } = new List<UsysAlertInstance>();

    [InverseProperty("AlertSchedule")]
    public virtual ICollection<UsysAlertScheduleRecipient> UsysAlertScheduleRecipients { get; set; } = new List<UsysAlertScheduleRecipient>();
}
