using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_5010_GS")]
public partial class Lnk834W5010G
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(2)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("ApplicationIdentifierCode-GS01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ApplicationIdentifierCodeGs01 { get; set; }

    [Column("ApplicationSenderCode-GS02")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ApplicationSenderCodeGs02 { get; set; }

    [Column("ApplicationReceiverCode-GS03")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ApplicationReceiverCodeGs03 { get; set; }

    [Column("Date-GS04")]
    [StringLength(8)]
    [Unicode(false)]
    public string? DateGs04 { get; set; }

    [Column("Time-GS05")]
    [StringLength(4)]
    [Unicode(false)]
    public string? TimeGs05 { get; set; }

    [Column("GroupControlNumber-GS06")]
    [StringLength(9)]
    [Unicode(false)]
    public string? GroupControlNumberGs06 { get; set; }

    [Column("ResponsibleAgencyCode-GS07")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ResponsibleAgencyCodeGs07 { get; set; }

    [Column("VerRelIndIDCode-GS08")]
    [StringLength(12)]
    [Unicode(false)]
    public string? VerRelIndIdcodeGs08 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
