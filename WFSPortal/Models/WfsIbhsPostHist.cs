using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("WFS IBHS Post Hist")]
public partial class WfsIbhsPostHist
{
    [StringLength(50)]
    [Unicode(false)]
    public string? CanceledFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InactiveFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OnHoldFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsCurrent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CostCenter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Division { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FunctionalArea { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Job { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrgPublisherPositionType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReportsToPosition { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CurrentPositionStatus { get; set; }

    [Column("PITPositionStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PitpositionStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Project { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Region { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Section { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Shift { get; set; }
}
