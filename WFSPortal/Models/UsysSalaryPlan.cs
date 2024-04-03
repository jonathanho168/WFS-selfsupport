using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlan")]
[Index("SalaryPlanName", Name = "UK_SalaryPlanName", IsUnique = true)]
public partial class UsysSalaryPlan
{
    [StringLength(80)]
    public string SalaryPlanName { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualBasePayBudget { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AnnualBasePayBudgetStartDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualOtherPayBudget { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AnnualOtherPayBudgetStartDate { get; set; }

    public bool CumulativeCalculationFlag { get; set; }

    public bool AllowAddRemoveBasePayFlag { get; set; }

    public bool AllowAddRemoveOtherPayFlag { get; set; }

    [StringLength(15)]
    public string? SalaryPlanStatusCode { get; set; }

    [Key]
    [Column("SalaryPlanGUID")]
    public Guid SalaryPlanGuid { get; set; }

    public int RowVersion { get; set; }

    public bool CalculateOtherPayOnCurrentFlag { get; set; }

    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    [Column("ModelApprovedByGUID")]
    public Guid? ModelApprovedByGuid { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string? SalaryPlanPerformanceMatrixCode { get; set; }

    [ForeignKey("CurrencyCode")]
    [InverseProperty("UsysSalaryPlans")]
    public virtual TCurrency CurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ModelApprovedByGuid")]
    [InverseProperty("UsysSalaryPlans")]
    public virtual TPerson? ModelApprovedBy { get; set; }

    [ForeignKey("SalaryPlanPerformanceMatrixCode")]
    [InverseProperty("UsysSalaryPlans")]
    public virtual UsysSalaryPlanPerformanceMatrix? SalaryPlanPerformanceMatrixCodeNavigation { get; set; }

    [ForeignKey("SalaryPlanStatusCode")]
    [InverseProperty("UsysSalaryPlans")]
    public virtual UsysSalaryPlanStatus? SalaryPlanStatusCodeNavigation { get; set; }

    [InverseProperty("SalaryPlan")]
    public virtual ICollection<UsysSalaryPlanBasePayDetail> UsysSalaryPlanBasePayDetails { get; set; } = new List<UsysSalaryPlanBasePayDetail>();

    [InverseProperty("SalaryPlan")]
    public virtual ICollection<UsysSalaryPlanOtherPayDetail> UsysSalaryPlanOtherPayDetails { get; set; } = new List<UsysSalaryPlanOtherPayDetail>();

    [InverseProperty("SalaryPlan")]
    public virtual ICollection<UsysSalaryPlanPerson> UsysSalaryPlanPeople { get; set; } = new List<UsysSalaryPlanPerson>();
}
