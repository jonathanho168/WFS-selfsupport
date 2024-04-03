using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_Metlife_w_5010_BGN")]
public partial class LnkMetlifeW5010Bgn
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("TransactionSetPurposeCode-BGN01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? TransactionSetPurposeCodeBgn01 { get; set; }

    [Column("ReferenceID-BGN02")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceIdBgn02 { get; set; }

    [Column("Date-BGN03")]
    [StringLength(8)]
    [Unicode(false)]
    public string? DateBgn03 { get; set; }

    [Column("Time0BGN04")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Time0Bgn04 { get; set; }

    [Column("TimeCode-BGN05")]
    [StringLength(2)]
    [Unicode(false)]
    public string? TimeCodeBgn05 { get; set; }

    [Column("ReferenceID-BGN06")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceIdBgn06 { get; set; }

    [Column("TransactionType-BGN07")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransactionTypeBgn07 { get; set; }

    [Column("ActionCode-BGN08")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ActionCodeBgn08 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
