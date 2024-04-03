using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceReviewType")]
[Index("PerformanceReviewTypeGuid", Name = "RG_tPerformanceReviewType", IsUnique = true)]
public partial class TPerformanceReviewType
{
    [Key]
    [StringLength(15)]
    public string PerformanceReviewTypeCode { get; set; } = null!;

    [Column("PerformanceReviewTypeGUID")]
    public Guid PerformanceReviewTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PerformanceReviewTypeDescription { get; set; }

    [InverseProperty("PerformanceReviewTypeCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionReviewType> TPerformanceQuestionReviewTypes { get; set; } = new List<TPerformanceQuestionReviewType>();

    [InverseProperty("PerformanceReviewTypeCodeNavigation")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHists { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("PerformanceReviewTypeCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanPerformanceMatrix> UsysSalaryPlanPerformanceMatrices { get; set; } = new List<UsysSalaryPlanPerformanceMatrix>();
}
