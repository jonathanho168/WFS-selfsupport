using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionReviewType")]
public partial class TPerformanceQuestionReviewType
{
    [Key]
    [Column("PerformanceQuestionReviewTypeGUID")]
    public Guid PerformanceQuestionReviewTypeGuid { get; set; }

    [StringLength(15)]
    public string PerformanceQuestionCode { get; set; } = null!;

    [StringLength(15)]
    public string PerformanceReviewTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceQuestionCode")]
    [InverseProperty("TPerformanceQuestionReviewTypes")]
    public virtual TPerformanceQuestion PerformanceQuestionCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceReviewTypeCode")]
    [InverseProperty("TPerformanceQuestionReviewTypes")]
    public virtual TPerformanceReviewType PerformanceReviewTypeCodeNavigation { get; set; } = null!;
}
