using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_w_ADPTime100027")]
public partial class LnkV1gWAdptime100027
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

    [StringLength(20)]
    [Unicode(false)]
    public string? FileNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Hours3Code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Hours3Amount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegularHours { get; set; }

    [Column("OTHours")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Othours { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TempRate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TempDept { get; set; }
}
