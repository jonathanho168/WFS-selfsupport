using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanOtherPayDetail")]
public partial class UsysSalaryPlanOtherPayDetail
{
    [Key]
    [Column("SalaryPlanOtherPayDetailGUID")]
    public Guid SalaryPlanOtherPayDetailGuid { get; set; }

    [StringLength(15)]
    public string PersonOtherPayReasonCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayStartDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageChange { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AmountChange { get; set; }

    [StringLength(15)]
    public string AmountChangeFrequencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledOtherPayReviewDate { get; set; }

    public int RowVersion { get; set; }

    [Column("SalaryPlanGUID")]
    public Guid SalaryPlanGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayEndDate { get; set; }

    [StringLength(15)]
    public string PersonOtherPayTypeCode { get; set; } = null!;

    [ForeignKey("AmountChangeFrequencyCode")]
    [InverseProperty("UsysSalaryPlanOtherPayDetails")]
    public virtual TFrequency AmountChangeFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayReasonCode")]
    [InverseProperty("UsysSalaryPlanOtherPayDetails")]
    public virtual TOtherPayReason PersonOtherPayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonOtherPayTypeCode")]
    [InverseProperty("UsysSalaryPlanOtherPayDetails")]
    public virtual TOtherPayType PersonOtherPayTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("SalaryPlanGuid")]
    [InverseProperty("UsysSalaryPlanOtherPayDetails")]
    public virtual UsysSalaryPlan SalaryPlan { get; set; } = null!;
}
