using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonOtherPayHist")]
[Index("PersonGuid", "PersonOtherPayStartDate", "PositionCode", "OtherPayTypeCode", Name = "AK_tPersonOtherPayHist", IsUnique = true)]
public partial class TPersonOtherPayHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonOtherPayStartDate { get; set; }

    [StringLength(15)]
    public string OtherPayTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayEndDate { get; set; }

    [StringLength(15)]
    public string PersonOtherPayCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PersonOtherPayAmount { get; set; }

    [StringLength(15)]
    public string PersonOtherPayFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonOtherPayPayrollFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string OtherPayReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string PayrollCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PlannedStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlannedEndDate { get; set; }

    [StringLength(15)]
    public string PlannedCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PlannedAmount { get; set; }

    [StringLength(15)]
    public string PlannedFrequencyCode { get; set; } = null!;

    public bool PersonOtherPayCurrentFlag { get; set; }

    [Key]
    [Column("PersonOtherPayGUID")]
    public Guid PersonOtherPayGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    public bool ExcludeInGenderPayGapReportFlag { get; set; }

    public byte[]? ReferralFormAttachment { get; set; }

    public Guid? ReferringEmployee { get; set; }

    [ForeignKey("OtherPayReasonCode")]
    [InverseProperty("TPersonOtherPayHists")]
    public virtual TOtherPayReason OtherPayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherPayTypeCode")]
    [InverseProperty("TPersonOtherPayHists")]
    public virtual TOtherPayType OtherPayTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PayrollCode")]
    [InverseProperty("TPersonOtherPayHists")]
    public virtual TPayroll PayrollCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonOtherPayHistPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonOtherPayCurrencyCode")]
    [InverseProperty("TPersonOtherPayHistPersonOtherPayCurrencyCodeNavigations")]
    public virtual TCurrency PersonOtherPayCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayFrequencyCode")]
    [InverseProperty("TPersonOtherPayHistPersonOtherPayFrequencyCodeNavigations")]
    public virtual TFrequency PersonOtherPayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayPayrollFrequencyCode")]
    [InverseProperty("TPersonOtherPayHistPersonOtherPayPayrollFrequencyCodeNavigations")]
    public virtual TFrequency PersonOtherPayPayrollFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PlannedCurrencyCode")]
    [InverseProperty("TPersonOtherPayHistPlannedCurrencyCodeNavigations")]
    public virtual TCurrency PlannedCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PlannedFrequencyCode")]
    [InverseProperty("TPersonOtherPayHistPlannedFrequencyCodeNavigations")]
    public virtual TFrequency PlannedFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPersonOtherPayHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ReferringEmployee")]
    [InverseProperty("TPersonOtherPayHistReferringEmployeeNavigations")]
    public virtual TPerson? ReferringEmployeeNavigation { get; set; }

    [InverseProperty("PersonOtherPay")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();
}
