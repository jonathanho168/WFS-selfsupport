using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UPMC_w_5010_2000_REF0F")]
public partial class LnkUpmcW50102000Ref0f
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("ReferenceIDQualifier-REF01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ReferenceIdqualifierRef01 { get; set; }

    [Column("ReferenceID-REF02")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceIdRef02 { get; set; }

    [Column("ReferenceID-REF02_enc")]
    [StringLength(255)]
    public string? ReferenceIdRef02Enc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
