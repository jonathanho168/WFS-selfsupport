using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptBaseCalculationsConverted
{
    [Column(TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    public int? Age { get; set; }

    [Column(TypeName = "money")]
    public decimal? AmountChange { get; set; }

    [Column(TypeName = "money")]
    public decimal? AnnualRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? BiWeeklyRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CompaRatio { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyDescription { get; set; }

    [StringLength(4)]
    public string? CurrencySymbol { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? MonthlyRate { get; set; }

    public int? NumberOfServiceDays { get; set; }

    public int? NumberOfServiceMonths { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "numeric(38, 6)")]
    public decimal? PercentChange { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AnnualRateEffectiveDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PersonBasePayAmount { get; set; }

    [StringLength(15)]
    public string PersonBasePayFrequencyCode { get; set; } = null!;

    public string? PersonBasePayFrequency { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PersonID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreviousAnnualRateEffectiveDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrevAnnualRate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PrevPersonBasePayAmount { get; set; }

    [StringLength(15)]
    public string? PrevPersonBasePayFrequencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMidAmount { get; set; }

    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;

    public string? ScheduleDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? SemiMonthlyRate { get; set; }

    [StringLength(34)]
    [Unicode(false)]
    public string? ServiceYears { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? ServiceYearsMonths { get; set; }

    [StringLength(107)]
    [Unicode(false)]
    public string? ServiceYearsMonthsDays { get; set; }

    [Column(TypeName = "money")]
    public decimal? WeeklyRate { get; set; }
}
