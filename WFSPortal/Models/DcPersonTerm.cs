using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonTerm")]
public partial class DcPersonTerm
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EligibleForRehireFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinalCheckReadyDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastWorkDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NoticeGivenDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TerminationReasonCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TerminationTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecommendForRehire { get; set; }
}
