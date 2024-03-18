using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCostCenter")]
[Index("CostCenterGuid", Name = "RG_tCostCenter", IsUnique = true)]
public partial class TCostCenter
{
    [Key]
    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("CostCenterGUID")]
    public Guid CostCenterGuid { get; set; }

    public int RowVersion { get; set; }

    public string? CostCenterDescription { get; set; }

    [InverseProperty("CostCenterCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("CostCenterCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("AllocationCostCenter1Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter1Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("AllocationCostCenter2Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter2Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("AllocationCostCenter3Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter3Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("AllocationCostCenter4Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter4Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("AllocationCostCenter5Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter5Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("AllocationCostCenter6Navigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHistAllocationCostCenter6Navigations { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("CostCenterCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
