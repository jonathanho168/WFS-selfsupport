using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRequisition")]
[Index("RequisitionGuid", Name = "RG_tRequisition", IsUnique = true)]
public partial class TRequisition
{
    [Key]
    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [StringLength(15)]
    public string ExternalRecruiterCode { get; set; } = null!;

    [Column("InternalRecruiterPersonGUID")]
    public Guid? InternalRecruiterPersonGuid { get; set; }

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

    public string? Comments { get; set; }

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

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

    [Column("LastModifiedByPersonGUID")]
    public Guid? LastModifiedByPersonGuid { get; set; }

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

    public Guid? ExternalTaskDataGuid { get; set; }

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

    [ForeignKey("ApprovedByPersonGuid")]
    [InverseProperty("TRequisitionApprovedByPeople")]
    public virtual TPerson? ApprovedByPerson { get; set; }

    [ForeignKey("CreatedByPersonGuid")]
    [InverseProperty("TRequisitionCreatedByPeople")]
    public virtual TPerson? CreatedByPerson { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TRequisitions")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("ExternalRecruiterCode")]
    [InverseProperty("TRequisitions")]
    public virtual TExternalRecruiter ExternalRecruiterCodeNavigation { get; set; } = null!;

    [ForeignKey("ExternalTaskDataGuid")]
    [InverseProperty("TRequisitionExternalTaskData")]
    public virtual UsysTaskDatum? ExternalTaskData { get; set; }

    [ForeignKey("InternalRecruiterPersonGuid")]
    [InverseProperty("TRequisitionInternalRecruiterPeople")]
    public virtual TPerson? InternalRecruiterPerson { get; set; }

    [ForeignKey("InternalTaskDataGuid")]
    [InverseProperty("TRequisitionInternalTaskData")]
    public virtual UsysTaskDatum? InternalTaskData { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TRequisitions")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("LastModifiedByPersonGuid")]
    [InverseProperty("TRequisitionLastModifiedByPeople")]
    public virtual TPerson? LastModifiedByPerson { get; set; }

    [ForeignKey("LocationCode")]
    [InverseProperty("TRequisitions")]
    public virtual TLocation LocationCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TRequisitions")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ReportsToPersonGuid")]
    [InverseProperty("TRequisitionReportsToPeople")]
    public virtual TPerson? ReportsToPerson { get; set; }

    [ForeignKey("StatusCategoryCode")]
    [InverseProperty("TRequisitions")]
    public virtual TStatusCategory StatusCategoryCodeNavigation { get; set; } = null!;

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TPersonApplication> TPersonApplications { get; set; } = new List<TPersonApplication>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TPersonForwardedApplication> TPersonForwardedApplications { get; set; } = new List<TPersonForwardedApplication>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TRecruitingExpense> TRecruitingExpenses { get; set; } = new List<TRecruitingExpense>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TRequisitionEmployeesHired> TRequisitionEmployeesHireds { get; set; } = new List<TRequisitionEmployeesHired>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TRequisitionEmployeesReplaced> TRequisitionEmployeesReplaceds { get; set; } = new List<TRequisitionEmployeesReplaced>();

    [InverseProperty("RequisitionCodeNavigation")]
    public virtual ICollection<TRequisitionJobDescriptionHist> TRequisitionJobDescriptionHists { get; set; } = new List<TRequisitionJobDescriptionHist>();

    [ForeignKey("TaskDataGuid")]
    [InverseProperty("TRequisitionTaskData")]
    public virtual UsysTaskDatum? TaskData { get; set; }
}
