using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tSurveyData")]
[Index("SurveyGuid", "JobCode", "GeographicAreaCode", "IndustrySectorCode", "SurveyCompanySizeCode", Name = "AK_tSurveyData", IsUnique = true)]
public partial class TSurveyDatum
{
    [Column("SurveyGUID")]
    public Guid SurveyGuid { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string GeographicAreaCode { get; set; } = null!;

    [StringLength(15)]
    public string IndustrySectorCode { get; set; } = null!;

    [StringLength(15)]
    public string SurveyCompanySizeCode { get; set; } = null!;

    [StringLength(15)]
    public string? SurveyJobNumber { get; set; }

    [StringLength(80)]
    public string? SurveyJobTitle { get; set; }

    public int? SurveyJobEvaluationPoints { get; set; }

    [StringLength(20)]
    public string? SurveyJobAverageYearsRelatedExperience { get; set; }

    public int? SurveyJobCompanyCount { get; set; }

    public int? SurveyJobIncumbentCount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal GoodFitAdjustmentFactor { get; set; }

    [StringLength(15)]
    public string SurveyCurrencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SurveyFrequencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? BasePayMaximumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePay90PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePay75PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePay50PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePay25PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePay10PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePayMinimumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePayAverageAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? BasePayWeightedAverageAmount { get; set; }

    public bool BonusEligibleFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? AverageBonusAmount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? AverageBonusPercent { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCashMaximumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCash90PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCash75PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCash50PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCash25PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCash10PercentileAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCashMinimumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCashAverageAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCashWeightedAverageAmount { get; set; }

    [Key]
    [Column("SurveyDataGUID")]
    public Guid SurveyDataGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("GeographicAreaCode")]
    [InverseProperty("TSurveyData")]
    public virtual TGeographicArea GeographicAreaCodeNavigation { get; set; } = null!;

    [ForeignKey("IndustrySectorCode")]
    [InverseProperty("TSurveyData")]
    public virtual TIndustrySector IndustrySectorCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TSurveyData")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyGuid")]
    [InverseProperty("TSurveyData")]
    public virtual TSurvey Survey { get; set; } = null!;

    [ForeignKey("SurveyCompanySizeCode")]
    [InverseProperty("TSurveyData")]
    public virtual TSurveyCompanySize SurveyCompanySizeCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyCurrencyCode")]
    [InverseProperty("TSurveyData")]
    public virtual TCurrency SurveyCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SurveyFrequencyCode")]
    [InverseProperty("TSurveyData")]
    public virtual TFrequency SurveyFrequencyCodeNavigation { get; set; } = null!;
}
