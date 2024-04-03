using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_VBA_w_5010_N1Payer")]
public partial class LnkVbaW5010N1payer
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("EntityIDCode-N101")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EntityIdcodeN101 { get; set; }

    [Column("Name-N102")]
    [StringLength(60)]
    [Unicode(false)]
    public string? NameN102 { get; set; }

    [Column("IDCodeQualifier-N103")]
    [StringLength(2)]
    [Unicode(false)]
    public string? IdcodeQualifierN103 { get; set; }

    [Column("IDCode-N104")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdcodeN104 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
