using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UHC_w_5010_REF38")]
public partial class LnkUhcW5010Ref38
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("ReferencyIDQualifier-REF01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ReferencyIdqualifierRef01 { get; set; }

    [Column("ReferenceID-REF02")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceIdRef02 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
