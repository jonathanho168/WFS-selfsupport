using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitParametersHist")]
public partial class TBenefitParametersHist
{
    [Column(TypeName = "datetime")]
    public DateTime BenefitParametersStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitParametersEndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageRoundTo { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageMinimum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageMultiplier { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageDivisor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerRoundTo { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerMinimum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerMultiplier { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployerDivisor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeRoundTo { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeMinimum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeMultiplier { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeDivisor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PremiumValue { get; set; }

    public bool BenefitParametersCurrentFlag { get; set; }

    [Key]
    [Column("BenefitParametersHistGUID")]
    public Guid BenefitParametersHistGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? CoverageFormula { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageMaxMultiplier { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CoverageMaxValue { get; set; }

    [StringLength(15)]
    public string CoverageMaxCompareToPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string? CoverageRoundType { get; set; }

    [Column("CoverageEOIMultiplier", TypeName = "decimal(19, 4)")]
    public decimal? CoverageEoimultiplier { get; set; }

    [Column("CoverageEOIValue", TypeName = "decimal(19, 4)")]
    public decimal? CoverageEoivalue { get; set; }

    [StringLength(15)]
    public string? CoverageRangeTypeCode { get; set; }

    [StringLength(15)]
    public string? EmployeeFormula { get; set; }

    [StringLength(15)]
    public string? EmployeeRoundType { get; set; }

    [StringLength(15)]
    public string? EmployeeRangeTypeCode { get; set; }

    [StringLength(15)]
    public string? EmployerFormula { get; set; }

    [StringLength(15)]
    public string? EmployerRoundType { get; set; }

    [StringLength(15)]
    public string? EmployerRangeTypeCode { get; set; }

    [StringLength(15)]
    public string? PremiumFormula { get; set; }

    [StringLength(15)]
    public string? SpendType { get; set; }

    [StringLength(15)]
    public string? SpendPayrollsNumericValueRef { get; set; }

    [StringLength(15)]
    public string? RetireType { get; set; }

    [StringLength(15)]
    public string? AgeType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AgeDay { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AgeMonth { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SalaryDay { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SalaryMonth { get; set; }

    [StringLength(15)]
    public string? SalaryAlternate { get; set; }

    [StringLength(80)]
    public string? ParameterOneLabel { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ParameterOneValue { get; set; }

    [StringLength(80)]
    public string? ParameterTwoLabel { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ParameterTwoValue { get; set; }

    [StringLength(80)]
    public string? ParameterThreeLabel { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ParameterThreeValue { get; set; }

    [StringLength(80)]
    public string? ParameterFourLabel { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ParameterFourValue { get; set; }

    [StringLength(80)]
    public string? ParameterFiveLabel { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ParameterFiveValue { get; set; }

    [StringLength(80)]
    public string? ParameterSixLabel { get; set; }

    [StringLength(15)]
    public string? ParameterSixValue { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeePreTax { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeePostTax { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedRoundTo { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedMinimum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedMaximum { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedMultiplier { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedDivisor { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ImputedExtraParameter { get; set; }

    [StringLength(15)]
    public string? ImputedRangeTypeCode { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string? CoverageSymbol { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("TBenefitParametersHists")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("CoverageMaxCompareToPlanCode")]
    [InverseProperty("TBenefitParametersHists")]
    public virtual TBenefitPlan CoverageMaxCompareToPlanCodeNavigation { get; set; } = null!;
}
