using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_w_ADPTime100028")]
public partial class LnkV1gWAdptime100028
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [Column("BatchID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BatchId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Hours3Code { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? Hours3Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Hours4Code { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Hours4Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Hours5Code { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Hours5Amount { get; set; }

    [Column(TypeName = "numeric(15, 2)")]
    public decimal? RegularHours { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RegEarnings { get; set; }

    [Column("OTHours")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Othours { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? TempRate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TempDept { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Hours { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TimeType { get; set; }

    [Column("TimeGUID")]
    [StringLength(125)]
    [Unicode(false)]
    public string? TimeGuid { get; set; }

    [Column(TypeName = "numeric(2, 0)")]
    public decimal? Control { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? OvertimeStatus { get; set; }
}
