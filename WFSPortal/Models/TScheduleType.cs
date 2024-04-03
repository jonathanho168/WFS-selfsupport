using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tScheduleType")]
[Index("ScheduleTypeGuid", Name = "RG_tScheduleType", IsUnique = true)]
public partial class TScheduleType
{
    [Key]
    [StringLength(15)]
    public string ScheduleTypeCode { get; set; } = null!;

    [Column("ScheduleTypeGUID")]
    public Guid ScheduleTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ScheduleTypeDescription { get; set; }

    [InverseProperty("ScheduleTypeCodeNavigation")]
    public virtual ICollection<TSchedule> TSchedules { get; set; } = new List<TSchedule>();
}
