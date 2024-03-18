using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VOrgPublisherPosition
{
    [Column("OrgPublisherPositionGUID")]
    public Guid? OrgPublisherPositionGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? ReportsToPositionCode { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(90)]
    public string? PositionTitle { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PositionTypeCode { get; set; } = null!;

    public string? PositionStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PositionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PositionEndDate { get; set; }
}
