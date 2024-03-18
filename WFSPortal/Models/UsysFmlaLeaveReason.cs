using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysFmlaLeaveReason")]
[Index("SysFmlaLeaveReasonGuid", Name = "AK_USysFmlaLeaveReason", IsUnique = true)]
public partial class UsysFmlaLeaveReason
{
    public Guid SysFmlaLeaveReasonGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string SysFmlaLeaveReasonCode { get; set; } = null!;

    public bool EmployeeMaternityPaternityFlag { get; set; }

    public bool EmployeeAdoptionFlag { get; set; }

    public bool EmployeeHealthFlag { get; set; }

    public bool FamilyHealthFlag { get; set; }

    public bool MilitaryCaregiverFlag { get; set; }

    public bool MilitaryExigencyFlag { get; set; }

    public bool MilitaryFmlaFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? SysFmlaLeaveReasonDescription { get; set; }

    [InverseProperty("FmlaLeaveReasonCodeNavigation")]
    public virtual ICollection<TPersonLeaveRequest> TPersonLeaveRequests { get; set; } = new List<TPersonLeaveRequest>();
}
