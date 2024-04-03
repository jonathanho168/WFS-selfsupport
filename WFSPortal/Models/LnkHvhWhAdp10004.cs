using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_HVH_wh_ADP10004")]
public partial class LnkHvhWhAdp10004
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("PositionID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PositionId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeductionCode { get; set; }

    [Column(TypeName = "numeric(7, 2)")]
    public decimal? DeductionAmt { get; set; }

    [Column(TypeName = "numeric(7, 2)")]
    public decimal? DeductionFactor { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? EmpContribAmt { get; set; }

    [Column(TypeName = "numeric(22, 18)")]
    public decimal? PeriodFactor { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ToPayFrequency { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? NumericValue1 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FromBenefitFrequencyCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RollupCode { get; set; }
}
