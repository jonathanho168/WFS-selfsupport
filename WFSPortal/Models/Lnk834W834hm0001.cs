using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("lnk_834_w_834HM0001")]
public partial class Lnk834W834hm0001
{
    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }

    [Column("RecordID")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RecordId { get; set; }

    [Column("AuthInfoQualifier-ISA01")]
    [StringLength(2)]
    [Unicode(false)]
    public string? AuthInfoQualifierIsa01 { get; set; }

    [Column("AuthInfo-ISA02")]
    [StringLength(10)]
    [Unicode(false)]
    public string? AuthInfoIsa02 { get; set; }

    [Column("SecurityInfoQualifier-ISA03")]
    [StringLength(2)]
    [Unicode(false)]
    public string? SecurityInfoQualifierIsa03 { get; set; }

    [Column("SecurityInfo-ISA04")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SecurityInfoIsa04 { get; set; }

    [Column("IntechangeIDQualifier-ISA05")]
    [StringLength(2)]
    [Unicode(false)]
    public string? IntechangeIdqualifierIsa05 { get; set; }

    [Column("InterchangeSenderID-ISA06")]
    [StringLength(15)]
    [Unicode(false)]
    public string? InterchangeSenderIdIsa06 { get; set; }

    [Column("InterchangeIDQuailifier-ISA07")]
    [StringLength(2)]
    [Unicode(false)]
    public string? InterchangeIdquailifierIsa07 { get; set; }

    [Column("InterchangeReceiverId-ISA08")]
    [StringLength(15)]
    [Unicode(false)]
    public string? InterchangeReceiverIdIsa08 { get; set; }

    [Column("InterchangeDate-ISA09")]
    [StringLength(6)]
    [Unicode(false)]
    public string? InterchangeDateIsa09 { get; set; }

    [Column("InterchangeTime-ISA10")]
    [StringLength(4)]
    [Unicode(false)]
    public string? InterchangeTimeIsa10 { get; set; }

    [Column("InterchangeControlStandardsID-ISA11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InterchangeControlStandardsIdIsa11 { get; set; }

    [Column("InterchangeControlVerNum-ISA12")]
    [StringLength(5)]
    [Unicode(false)]
    public string? InterchangeControlVerNumIsa12 { get; set; }

    [Column("InterchangeControlNumber-ISA13")]
    [StringLength(9)]
    [Unicode(false)]
    public string? InterchangeControlNumberIsa13 { get; set; }

    [Column("AcknowledgmentRequested-ISA14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcknowledgmentRequestedIsa14 { get; set; }

    [Column("UsageIdentifier-ISA15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UsageIdentifierIsa15 { get; set; }

    [Column("ComponentElementSeparator-ISA16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ComponentElementSeparatorIsa16 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsiblePerson { get; set; }
}
