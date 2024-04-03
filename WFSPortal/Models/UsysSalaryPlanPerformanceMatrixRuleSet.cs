using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysSalaryPlanPerformanceMatrixRuleSet")]
public partial class UsysSalaryPlanPerformanceMatrixRuleSet
{
    [Key]
    [Column("SalaryPlanPerformanceMatrixRuleSetGUID")]
    public Guid SalaryPlanPerformanceMatrixRuleSetGuid { get; set; }

    [StringLength(15)]
    public string? SalaryPlanPerformanceMatrixCode { get; set; }

    [StringLength(15)]
    public string? PerformanceRatingCode { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MinimumScore { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MaximumScore { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MinimumIncreasePercentage { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MaximumIncreasePercentage { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceRatingCode")]
    [InverseProperty("UsysSalaryPlanPerformanceMatrixRuleSets")]
    public virtual TPerformanceRating? PerformanceRatingCodeNavigation { get; set; }

    [ForeignKey("SalaryPlanPerformanceMatrixCode")]
    [InverseProperty("UsysSalaryPlanPerformanceMatrixRuleSets")]
    public virtual UsysSalaryPlanPerformanceMatrix? SalaryPlanPerformanceMatrixCodeNavigation { get; set; }
}
