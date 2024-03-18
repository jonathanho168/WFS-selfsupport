using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLeaveReason")]
[Index("LeaveReasonGuid", Name = "RG_tLeaveReason", IsUnique = true)]
public partial class TLeaveReason
{
    [Key]
    [StringLength(15)]
    public string LeaveReasonCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("LeaveReasonGUID")]
    public Guid LeaveReasonGuid { get; set; }

    public int RowVersion { get; set; }

    public string? LeaveReasonDescription { get; set; }

    [InverseProperty("LeaveReasonCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequest> TPersonLeaveRequests { get; set; } = new List<TPersonLeaveRequest>();
}
