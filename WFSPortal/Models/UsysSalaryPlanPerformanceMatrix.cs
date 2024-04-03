using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanPerformanceMatrix")]
public partial class UsysSalaryPlanPerformanceMatrix
{
    [Column("SalaryPlanPerformanceMatrixGUID")]
    public Guid SalaryPlanPerformanceMatrixGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string SalaryPlanPerformanceMatrixCode { get; set; } = null!;

    public string? SalaryPlanPerformanceMatrixDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public bool ScoreBasedFlag { get; set; }

    public bool RatingBasedFlag { get; set; }

    [StringLength(15)]
    public string? PerformanceReviewTypeCode { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceReviewTypeCode")]
    [InverseProperty("UsysSalaryPlanPerformanceMatrices")]
    public virtual TPerformanceReviewType? PerformanceReviewTypeCodeNavigation { get; set; }

    [InverseProperty("SalaryPlanPerformanceMatrixCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanPerformanceMatrixRuleSet> UsysSalaryPlanPerformanceMatrixRuleSets { get; set; } = new List<UsysSalaryPlanPerformanceMatrixRuleSet>();

    [InverseProperty("SalaryPlanPerformanceMatrixCodeNavigation")]
    public virtual ICollection<UsysSalaryPlan> UsysSalaryPlans { get; set; } = new List<UsysSalaryPlan>();
}
