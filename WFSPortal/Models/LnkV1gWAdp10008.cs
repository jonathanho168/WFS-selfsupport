using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_w_ADP10008")]
public partial class LnkV1gWAdp10008
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [Column("BatchID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BatchId { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings3Code { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings3Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings4Code { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings4Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings5Code { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings5Amount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PayNumber { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TaxFrequency { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OtherPayTypeCode { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? OtherPayDate { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? OtherPayAmount { get; set; }

    [Column(TypeName = "numeric(2, 0)")]
    public decimal? Control { get; set; }
}
