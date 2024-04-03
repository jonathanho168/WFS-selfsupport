using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanBasePayPersonDetail")]
public partial class UsysSalaryPlanBasePayPersonDetail
{
    [Key]
    [Column("SalaryPlanBasePayPersonDetailGUID")]
    public Guid SalaryPlanBasePayPersonDetailGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayStartDate { get; set; }

    [StringLength(15)]
    public string PersonBasePayReasonCode { get; set; } = null!;

    [StringLength(15)]
    public string PersonBasePayChangeAmountFrequencyCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PersonBasePayChangeAmount { get; set; }

    [StringLength(15)]
    public string PersonBasePayFrequencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledBasePayReviewDate { get; set; }

    [Column("SalaryPlanPersonGUID")]
    public Guid SalaryPlanPersonGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageChange { get; set; }

    public int? SortOrder { get; set; }

    [StringLength(15)]
    public string? PerformanceRatingCode { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? PersonPerformanceFinalScore { get; set; }

    public string? BasePayJustification { get; set; }

    [ForeignKey("PerformanceRatingCode")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetails")]
    public virtual TPerformanceRating? PerformanceRatingCodeNavigation { get; set; }

    [ForeignKey("PersonBasePayChangeAmountFrequencyCode")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetailPersonBasePayChangeAmountFrequencyCodeNavigations")]
    public virtual TFrequency PersonBasePayChangeAmountFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBasePayFrequencyCode")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetailPersonBasePayFrequencyCodeNavigations")]
    public virtual TFrequency PersonBasePayFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBasePayReasonCode")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetails")]
    public virtual TBasePayReason PersonBasePayReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetails")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("SalaryPlanPersonGuid")]
    [InverseProperty("UsysSalaryPlanBasePayPersonDetails")]
    public virtual UsysSalaryPlanPerson SalaryPlanPerson { get; set; } = null!;
}
