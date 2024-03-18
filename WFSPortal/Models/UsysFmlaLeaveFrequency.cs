using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysFmlaLeaveFrequency")]
[Index("SysFmlaLeaveFrequencyGuid", Name = "AK_USysFmlaLeaveFrequency", IsUnique = true)]
public partial class UsysFmlaLeaveFrequency
{
    public Guid SysFmlaLeaveFrequencyGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string SysFmlaLeaveFrequencyCode { get; set; } = null!;

    public bool ReducedScheduleFlag { get; set; }

    public bool IntermittentScheduleFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SysFmlaLeaveFrequencyDescription { get; set; }

    [InverseProperty("FmlaLeaveFrequencyCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequest> TPersonLeaveRequests { get; set; } = new List<TPersonLeaveRequest>();
}
