using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_w_ADP10005")]
public partial class LnkV1gWAdp10005
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("PositionID")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PositionId { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? DeductionCode { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("ABARoutingNumber")]
    [StringLength(35)]
    [Unicode(false)]
    public string? AbaroutingNumber { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? DeductionAmount { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? PrimaryDepositFlag { get; set; }
}
