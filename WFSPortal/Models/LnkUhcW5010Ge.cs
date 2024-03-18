﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UHC_w_5010_GE")]
public partial class LnkUhcW5010Ge
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("NumberOfTransactionSetsIncluded-GE01")]
    [StringLength(6)]
    [Unicode(false)]
    public string? NumberOfTransactionSetsIncludedGe01 { get; set; }

    [Column("GroupControlNumber-GE02")]
    [StringLength(9)]
    [Unicode(false)]
    public string? GroupControlNumberGe02 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
