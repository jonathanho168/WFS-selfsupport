﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_Metlife_w_834ML2302")]
public partial class LnkMetlifeW834ml2302
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("DateTimeQualifier-DTP01")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateTimeQualifierDtp01 { get; set; }

    [Column("DateTimePeriodFormatQualifier-DTP02")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DateTimePeriodFormatQualifierDtp02 { get; set; }

    [Column("DateTimePeriod-DTP03")]
    [StringLength(35)]
    [Unicode(false)]
    public string? DateTimePeriodDtp03 { get; set; }

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
