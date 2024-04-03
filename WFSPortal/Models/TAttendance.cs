using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAttendance")]
[Index("AttendanceGuid", Name = "RG_tAttendance", IsUnique = true)]
public partial class TAttendance
{
    [Key]
    [StringLength(15)]
    public string AttendanceCode { get; set; } = null!;

    public bool DroppedFlag { get; set; }

    public bool CanceledFlag { get; set; }

    [Column("AttendanceGUID")]
    public Guid AttendanceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? AttendanceDescription { get; set; }

    [InverseProperty("AttendanceCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();
}
