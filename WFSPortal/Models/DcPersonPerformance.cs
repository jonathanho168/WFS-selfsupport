using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonPerformance")]
public partial class DcPersonPerformance
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonPerformanceStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonPerformanceEndDate { get; set; }

    [Column("RatedBySSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RatedBySsn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledReviewDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PerformedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerformanceRatingCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerformanceReviewTypeCode { get; set; }

    [Column("SupervisorSSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SupervisorSsn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FinalScore { get; set; }
}
