﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_UPMC_w_5010_IEA")]
public partial class LnkUpmcW5010Iea
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("NumberofFunctionalGroupsIncluded-IEA01")]
    [StringLength(5)]
    [Unicode(false)]
    public string? NumberofFunctionalGroupsIncludedIea01 { get; set; }

    [Column("GroupControlNumber-IEA02")]
    [StringLength(9)]
    [Unicode(false)]
    public string? GroupControlNumberIea02 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
