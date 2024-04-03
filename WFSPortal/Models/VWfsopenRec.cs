using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VWfsopenRec
{
    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [StringLength(15)]
    public string ExternalRecruiterCode { get; set; } = null!;

    [Column("InternalRecruiterPersonGUID")]
    public Guid? InternalRecruiterPersonGuid { get; set; }

    [StringLength(125)]
    public string? InternalRecruiter { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public bool FullTimeFlag { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("RequisitionGUID")]
    public Guid RequisitionGuid { get; set; }

    public bool CandidateSelfServiceFlag { get; set; }

    public bool EmployeeConnectFlag { get; set; }

    [Column("ApprovedByPersonGUID")]
    public Guid? ApprovedByPersonGuid { get; set; }

    [StringLength(125)]
    public string? ApprovedBy { get; set; }

    public string? Comments { get; set; }

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

    [StringLength(125)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    public int? Openings { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? HoursPerWeek { get; set; }

    public bool HiringReplacementFlag { get; set; }

    [Column("ReportsToPersonGUID")]
    public Guid? ReportsToPersonGuid { get; set; }

    [StringLength(125)]
    public string? ReportsTo { get; set; }

    [Column("LastModifiedByPersonGUID")]
    public Guid? LastModifiedByPersonGuid { get; set; }

    [StringLength(125)]
    public string? LastModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JobPositionStartDate { get; set; }

    public string? RecruitmentPlan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CandidateSelfServiceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeConnectStartDate { get; set; }

    public int RowVersion { get; set; }

    public Guid? TaskDataGuid { get; set; }

    public bool BudgetedFlag { get; set; }

    public bool? OpenFlag { get; set; }

    public string? RequisitionDescription { get; set; }

    [Column("ACT168")]
    public bool? Act168 { get; set; }

    public bool? VisaRequired { get; set; }

    public Guid? InternalTaskDataGuid { get; set; }

    [StringLength(150)]
    public string? InternalTemplate { get; set; }

    public Guid? ExternalTaskDataGuid { get; set; }

    [StringLength(150)]
    public string? ExternalTemplate { get; set; }

    [Column("JDReview")]
    public bool? Jdreview { get; set; }

    [Column("JDChanges")]
    public string? Jdchanges { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CandidateSelfServiceEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeConnectEndDate { get; set; }

    [StringLength(15)]
    public string StatusCategoryCode { get; set; } = null!;

    public bool MobileCandidateSelfServiceFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MobileCandidateSelfServiceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MobileCandidateSelfServiceEndDate { get; set; }

    public int? DaysOld { get; set; }
}
