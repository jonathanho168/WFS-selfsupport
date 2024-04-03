﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_834HM2101")]
public partial class Lnk834W834hm2101
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("ContactFunctionCode-PER01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ContactFunctionCodePer01 { get; set; }

    [Column("Name-PER02")]
    [StringLength(60)]
    [Unicode(false)]
    public string? NamePer02 { get; set; }

    [Column("CommunicationNumberQualifier-PER03")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CommunicationNumberQualifierPer03 { get; set; }

    [Column("CommunicationNumber-PER04")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CommunicationNumberPer04 { get; set; }

    [Column("CommunicationNumberQualifier-PER05")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CommunicationNumberQualifierPer05 { get; set; }

    [Column("CommunicationNumber-PER06")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CommunicationNumberPer06 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Relationship { get; set; }
}
