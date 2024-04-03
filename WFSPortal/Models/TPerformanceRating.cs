using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceRating")]
[Index("PerformanceRatingGuid", Name = "RG_tPerformanceRating", IsUnique = true)]
public partial class TPerformanceRating
{
    [Key]
    [StringLength(15)]
    public string PerformanceRatingCode { get; set; } = null!;

    [Column("PerformanceRatingGUID")]
    public Guid PerformanceRatingGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PerformanceRatingDescription { get; set; }

    [InverseProperty("PerformanceRatingCodeNavigation")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHists { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("PerformanceRatingCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetails { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();

    [InverseProperty("PerformanceRatingCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanPerformanceMatrixRuleSet> UsysSalaryPlanPerformanceMatrixRuleSets { get; set; } = new List<UsysSalaryPlanPerformanceMatrixRuleSet>();
}
