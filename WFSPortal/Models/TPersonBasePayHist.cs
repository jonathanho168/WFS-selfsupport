using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBasePayHist")]
public partial class TPersonBasePayHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBasePayStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayEndDate { get; set; }

    [StringLength(15)]
    public string PersonBasePayCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }

    [StringLength(15)]
    public string PersonBasePayFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonBasePayPayrollFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string BasePayReasonCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ConductedBasePayReviewDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }

    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    public bool PersonBasePayCurrentFlag { get; set; }

    [Column("ApprovedByPersonGUID")]
    public Guid? ApprovedByPersonGuid { get; set; }

    [Key]
    [Column("PersonBasePayGUID")]
    public Guid PersonBasePayGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;

    public string? Comments { get; set; }

    public bool ExcludeInGenderPayGapReportFlag { get; set; }

    [ForeignKey("ApprovedByPersonGuid")]
    [InverseProperty("TPersonBasePayHistApprovedByPeople")]
    public virtual TPerson? ApprovedByPerson { get; set; }

    [ForeignKey("BasePayReasonCode")]
    [InverseProperty("TPersonBasePayHists")]
    public virtual TBasePayReason BasePayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollCode")]
    [InverseProperty("TPersonBasePayHists")]
    public virtual TPayroll PayrollCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonBasePayHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonBasePayCurrencyCode")]
    [InverseProperty("TPersonBasePayHists")]
    public virtual TCurrency PersonBasePayCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBasePayFrequencyCode")]
    [InverseProperty("TPersonBasePayHistPersonBasePayFrequencyCodeNavigations")]
    public virtual TFrequency PersonBasePayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBasePayPayrollFrequencyCode")]
    [InverseProperty("TPersonBasePayHistPersonBasePayPayrollFrequencyCodeNavigations")]
    public virtual TFrequency PersonBasePayPayrollFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonBasePayHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ScheduleCode")]
    [InverseProperty("TPersonBasePayHists")]
    public virtual TSchedule ScheduleCodeNavigation { get; set; } = null!;
}
