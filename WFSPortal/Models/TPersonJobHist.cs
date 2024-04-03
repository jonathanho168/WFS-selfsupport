using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonJobHist")]
[Index("PositionCode", "PersonJobStartDate", Name = "IX_tPersonJobHist_PositionCode_PersonJobStartDate")]
public partial class TPersonJobHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonJobStartDate { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public bool PrimaryPositionFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobEndDate { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string JobReasonCode { get; set; } = null!;

    [StringLength(80)]
    public string? BusinessCardTitle { get; set; }

    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [StringLength(15)]
    public string GradeLocationCode { get; set; } = null!;

    [StringLength(15)]
    public string Step { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FullTimeEquivalent { get; set; }

    public bool PersonJobCurrentFlag { get; set; }

    [Key]
    [Column("PersonJobGUID")]
    public Guid PersonJobGuid { get; set; }

    [StringLength(15)]
    public string OrgPublisherPositionTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string RequisitionCode { get; set; } = null!;

    public string? Comments { get; set; }

    [StringLength(15)]
    public string? DriverStatus { get; set; }

    [StringLength(15)]
    public string? NoticePeriodEmployerIndicator { get; set; }

    [StringLength(80)]
    public string? EmployerNoticeofTermination { get; set; }

    [StringLength(15)]
    public string? NoticePeriodEmployeeIndicator { get; set; }

    [StringLength(80)]
    public string? EmployeeNoticeofTermination { get; set; }

    [ForeignKey("DriverStatus")]
    [InverseProperty("TPersonJobHists")]
    public virtual TDriverStatus? DriverStatusNavigation { get; set; }

    [ForeignKey("GradeLocationCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TLocation GradeLocationCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("JobReasonCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TJobReason JobReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("NoticePeriodEmployeeIndicator")]
    [InverseProperty("TPersonJobHistNoticePeriodEmployeeIndicatorNavigations")]
    public virtual TNoticePeriodEmployerIndicator? NoticePeriodEmployeeIndicatorNavigation { get; set; }

    [ForeignKey("NoticePeriodEmployerIndicator")]
    [InverseProperty("TPersonJobHistNoticePeriodEmployerIndicatorNavigations")]
    public virtual TNoticePeriodEmployerIndicator? NoticePeriodEmployerIndicatorNavigation { get; set; }

    [ForeignKey("OrgPublisherPositionTypeCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TOrgPublisherPositionType OrgPublisherPositionTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonJobHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TPersonJobHists")]
    public virtual TRequisition RequisitionCodeNavigation { get; set; } = null!;
}
