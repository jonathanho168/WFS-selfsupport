using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UHC_w_5010_2000_DTP300")]
public partial class LnkUhcW50102000Dtp300
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("DateTimeQualifier-DTP01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateTimeQualifierDtp01 { get; set; }

    [Column("DateTimeFormat-DTP02B")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateTimeFormatDtp02b { get; set; }

    [Column("DateTimePeriod-DTP03")]
    [StringLength(35)]
    [Unicode(false)]
    public string? DateTimePeriodDtp03 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
