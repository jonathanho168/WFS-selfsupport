using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_834HM0003")]
public partial class Lnk834W834hm0003
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("TransactionSetIDCode-ST01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? TransactionSetIdcodeSt01 { get; set; }

    [Column("TransactionSetControlNum-ST02")]
    [StringLength(9)]
    [Unicode(false)]
    public string? TransactionSetControlNumSt02 { get; set; }

    [Column("TransactionSetVersion-ST03")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionSetVersionSt03 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
