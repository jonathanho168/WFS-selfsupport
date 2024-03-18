using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGradeHist")]
public partial class TGradeHist
{
    [StringLength(15)]
    public string GradeCode { get; set; } = null!;

    [StringLength(15)]
    public string GradeLocationCode { get; set; } = null!;

    [StringLength(15)]
    public string Step { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime GradeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GradeEndDate { get; set; }

    [StringLength(15)]
    public string GradeCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? StepAmount { get; set; }

    [StringLength(15)]
    public string GradeFrequencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? RangeMaximumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMidAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? RangeMinimumAmount { get; set; }

    public bool GradeCurrentFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? MarketMaximumAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? MarketMidAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? MarketMinimumAmount { get; set; }

    [Key]
    [Column("GradeGUID")]
    public Guid GradeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("GradeCurrencyCode")]
    [InverseProperty("TGradeHists")]
    public virtual TCurrency GradeCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("GradeFrequencyCode")]
    [InverseProperty("TGradeHists")]
    public virtual TFrequency GradeFrequencyCodeNavigation { get; set; } = null!;

    [ForeignKey("GradeLocationCode")]
    [InverseProperty("TGradeHists")]
    public virtual TLocation GradeLocationCodeNavigation { get; set; } = null!;
}
