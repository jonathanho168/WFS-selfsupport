using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_6BV_w_ADP10003")]
public partial class Lnk6bvWAdp10003
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("PositionID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PositionId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeductionCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeductionAmount { get; set; }

    [Column("Factor_DedCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FactorDedCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeductionFactor { get; set; }
}
