using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_834HM9991")]
public partial class Lnk834W834hm9991
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("NumberOfIncludedSegments-SE01")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NumberOfIncludedSegmentsSe01 { get; set; }

    [Column("TransactionSetControlNumber-SE02")]
    [StringLength(9)]
    [Unicode(false)]
    public string? TransactionSetControlNumberSe02 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
