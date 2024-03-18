using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLeaveRequest")]
public partial class TPersonLeaveRequest
{
    [Key]
    [Column("PersonLeaveRequestGUID")]
    public Guid PersonLeaveRequestGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string LeaveTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string LeaveReasonCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    public bool SubmittedFlag { get; set; }

    public bool ClosedFlag { get; set; }

    [Column("FMLAFlag")]
    public bool Fmlaflag { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal TotalHours { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InitialApprovalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EligibilityFormsDueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinalApprovalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalExpirationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedReturnDate { get; set; }

    public string? EmployeeComments { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [Column("EmployeeRequestedFMLAFlag")]
    public bool EmployeeRequestedFmlaflag { get; set; }

    [Column("FMLALeaveReasonRelationship")]
    [StringLength(80)]
    public string? FmlaleaveReasonRelationship { get; set; }

    [StringLength(15)]
    public string? FmlaLeaveFrequencyCode { get; set; }

    [StringLength(15)]
    public string? FmlaLeaveReasonCode { get; set; }

    [ForeignKey("FmlaLeaveFrequencyCode")]
    [InverseProperty("TPersonLeaveRequests")]
    public virtual UsysFmlaLeaveFrequency? FmlaLeaveFrequencyCodeNavigation { get; set; }

    [ForeignKey("FmlaLeaveReasonCode")]
    [InverseProperty("TPersonLeaveRequests")]
    public virtual UsysFmlaLeaveReason? FmlaLeaveReasonCodeNavigation { get; set; }

    [ForeignKey("LeaveReasonCode")]
    [InverseProperty("TPersonLeaveRequests")]
    public virtual TLeaveReason LeaveReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("LeaveTypeCode")]
    [InverseProperty("TPersonLeaveRequests")]
    public virtual TLeaveType LeaveTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonLeaveRequests")]
    public virtual TPerson Person { get; set; } = null!;

    [InverseProperty("PersonLeaveRequest")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();

    [InverseProperty("PersonLeaveRequest")]
    public virtual ICollection<TPersonLeaveRequestDesignation> TPersonLeaveRequestDesignations { get; set; } = new List<TPersonLeaveRequestDesignation>();

    [InverseProperty("PersonLeaveRequest")]
    public virtual ICollection<TPersonLeaveRequestEligibility> TPersonLeaveRequestEligibilities { get; set; } = new List<TPersonLeaveRequestEligibility>();
}
