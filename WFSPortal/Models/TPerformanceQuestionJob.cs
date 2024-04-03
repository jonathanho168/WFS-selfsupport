using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionJob")]
public partial class TPerformanceQuestionJob
{
    [Key]
    [Column("PerformanceQuestionJobGUID")]
    public Guid PerformanceQuestionJobGuid { get; set; }

    [StringLength(15)]
    public string PerformanceQuestionCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TPerformanceQuestionJobs")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceQuestionCode")]
    [InverseProperty("TPerformanceQuestionJobs")]
    public virtual TPerformanceQuestion PerformanceQuestionCodeNavigation { get; set; } = null!;
}
