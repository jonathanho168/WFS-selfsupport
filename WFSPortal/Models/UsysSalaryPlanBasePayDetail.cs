using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanBasePayDetail")]
public partial class UsysSalaryPlanBasePayDetail
{
    [Key]
    [Column("SalaryPlanBasePayDetailGUID")]
    public Guid SalaryPlanBasePayDetailGuid { get; set; }

    [StringLength(15)]
    public string PersonBasePayReasonCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayStartDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageChange { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AmountChange { get; set; }

    [StringLength(15)]
    public string AmountChangeFrequencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }

    public int RowVersion { get; set; }

    [Column("SalaryPlanGUID")]
    public Guid SalaryPlanGuid { get; set; }

    public int? SortOrder { get; set; }

    [ForeignKey("AmountChangeFrequencyCode")]
    [InverseProperty("UsysSalaryPlanBasePayDetails")]
    public virtual TFrequency AmountChangeFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBasePayReasonCode")]
    [InverseProperty("UsysSalaryPlanBasePayDetails")]
    public virtual TBasePayReason PersonBasePayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("SalaryPlanGuid")]
    [InverseProperty("UsysSalaryPlanBasePayDetails")]
    public virtual UsysSalaryPlan SalaryPlan { get; set; } = null!;
}
