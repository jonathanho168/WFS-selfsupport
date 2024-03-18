using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_VBA_w")]
public partial class LnkVbaW
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("ReferenceIdentificationQualifier-REF01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ReferenceIdentificationQualifierRef01 { get; set; }

    [Column("ReferenceIdentification-REF02")]
    [StringLength(4)]
    [Unicode(false)]
    public string? ReferenceIdentificationRef02 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
