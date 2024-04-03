using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonJob")]
public partial class DcPersonJob
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrimaryPositionFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonJobEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BusinessCardTitle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobReasonCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GradeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FullTimeEquivalent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgPublisherPositionTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DriverStatus { get; set; }
}
