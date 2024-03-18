using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_V1G_wh_ADP10007")]
public partial class LnkV1gWhAdp10007
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? CompanyCode { get; set; }

    [Column("BatchID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BatchId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FileNumber { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings3Code { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? Earnings3Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings4Code { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? Earnings4Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Earnings5Code { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? Earnings5Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PayNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TaxFrequency { get; set; }
}
