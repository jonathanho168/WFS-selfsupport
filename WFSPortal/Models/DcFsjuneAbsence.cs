using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcFSJuneAbsence")]
public partial class DcFsjuneAbsence
{
    [Column("Tax ID (SSN)")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxIdSsn { get; set; }

    [Column("name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Plan { get; set; }

    [Column("Start Balance", TypeName = "money")]
    public decimal? StartBalance { get; set; }

    [Column("Start Date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }
}
