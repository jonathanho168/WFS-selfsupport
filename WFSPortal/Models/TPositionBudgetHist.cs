using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPositionBudgetHist")]
public partial class TPositionBudgetHist
{
    [Key]
    [Column("PositionBudgetGUID")]
    public Guid PositionBudgetGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PositionBudgetStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionBudgetEndDate { get; set; }

    public bool PositionBudgetCurrentFlag { get; set; }

    [StringLength(15)]
    public string PositionBudgetCurrencyCode { get; set; } = null!;

    [StringLength(80)]
    public string? AuthorizedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDate { get; set; }

    [Column("AuthorizedFTE", TypeName = "decimal(19, 4)")]
    public decimal? AuthorizedFte { get; set; }

    [Column(TypeName = "money")]
    public decimal? AuthorizedPayRate { get; set; }

    [StringLength(15)]
    public string? PayRateFrequencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? AuthorizedTotalAmount { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter1 { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter2 { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter3 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage1 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage2 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage3 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? RevisedBudgetSalaryWithIncrease { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter4 { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter5 { get; set; }

    [StringLength(15)]
    public string? AllocationCostCenter6 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage4 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage5 { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AllocationPercentage6 { get; set; }

    [ForeignKey("AllocationCostCenter1")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter1Navigations")]
    public virtual TCostCenter? AllocationCostCenter1Navigation { get; set; }

    [ForeignKey("AllocationCostCenter2")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter2Navigations")]
    public virtual TCostCenter? AllocationCostCenter2Navigation { get; set; }

    [ForeignKey("AllocationCostCenter3")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter3Navigations")]
    public virtual TCostCenter? AllocationCostCenter3Navigation { get; set; }

    [ForeignKey("AllocationCostCenter4")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter4Navigations")]
    public virtual TCostCenter? AllocationCostCenter4Navigation { get; set; }

    [ForeignKey("AllocationCostCenter5")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter5Navigations")]
    public virtual TCostCenter? AllocationCostCenter5Navigation { get; set; }

    [ForeignKey("AllocationCostCenter6")]
    [InverseProperty("TPositionBudgetHistAllocationCostCenter6Navigations")]
    public virtual TCostCenter? AllocationCostCenter6Navigation { get; set; }

    [ForeignKey("PayRateFrequencyCode")]
    [InverseProperty("TPositionBudgetHists")]
    public virtual TFrequency? PayRateFrequencyCodeNavigation { get; set; }

    [ForeignKey("PositionBudgetCurrencyCode")]
    [InverseProperty("TPositionBudgetHists")]
    public virtual TCurrency PositionBudgetCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPositionBudgetHists")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [InverseProperty("PositionBudget")]
    public virtual ICollection<TPositionFundingHist> TPositionFundingHists { get; set; } = new List<TPositionFundingHist>();
}
