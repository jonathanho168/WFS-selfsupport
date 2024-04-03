using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLeaveType")]
[Index("LeaveTypeGuid", Name = "RG_tLeaveType", IsUnique = true)]
public partial class TLeaveType
{
    [Key]
    [StringLength(15)]
    public string LeaveTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("LeaveTypeGUID")]
    public Guid LeaveTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? LeaveTypeDescription { get; set; }

    [Column("CSFCode")]
    [StringLength(15)]
    public string? Csfcode { get; set; }

    [Column("UKCSF_IsStatutorySickFlag")]
    public bool UkcsfIsStatutorySickFlag { get; set; }

    [ForeignKey("Csfcode")]
    [InverseProperty("TLeaveTypes")]
    public virtual UsysCsf? CsfcodeNavigation { get; set; }

    [InverseProperty("LeaveTypeCodeNavigation")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();

    [InverseProperty("LeaveTypeCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequest> TPersonLeaveRequests { get; set; } = new List<TPersonLeaveRequest>();
}
