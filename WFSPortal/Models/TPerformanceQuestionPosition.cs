using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPerformanceQuestionPosition")]
public partial class TPerformanceQuestionPosition
{
    [Key]
    [Column("PerformanceQuestionPositionGUID")]
    public Guid PerformanceQuestionPositionGuid { get; set; }

    [StringLength(15)]
    public string PerformanceQuestionCode { get; set; } = null!;

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("PerformanceQuestionCode")]
    [InverseProperty("TPerformanceQuestionPositions")]
    public virtual TPerformanceQuestion PerformanceQuestionCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TPerformanceQuestionPositions")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;
}
