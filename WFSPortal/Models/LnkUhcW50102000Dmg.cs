using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UHC_w_5010_2000_DMG")]
public partial class LnkUhcW50102000Dmg
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("DateTimeFormatQualifier-DMG01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateTimeFormatQualifierDmg01 { get; set; }

    [Column("DateTimePeriod-DMG02")]
    [StringLength(35)]
    [Unicode(false)]
    public string? DateTimePeriodDmg02 { get; set; }

    [Column("GenderCode-DMG03")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GenderCodeDmg03 { get; set; }

    [Column("MaritalStatusCode-DMG04")]
    [StringLength(5)]
    [Unicode(false)]
    public string? MaritalStatusCodeDmg04 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
