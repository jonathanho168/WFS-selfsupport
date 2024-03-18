using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_5010_2300_REF1L")]
public partial class Lnk834W50102300Ref1l
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

    [Column("ReferenceIdentification-REF02")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceIdentificationRef02 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? BenefitPlanCode { get; set; }
}
