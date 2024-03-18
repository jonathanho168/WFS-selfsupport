using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingInstanceHistory")]
[Index("PreviousRoutingInstanceHistoryGuid", Name = "IX_tRoutingInstanceHistory_PreviousRoutingInstanceHistoryGUID")]
public partial class UsysRoutingInstanceHistory
{
    [Key]
    [Column("RoutingInstanceHistoryGUID")]
    public Guid RoutingInstanceHistoryGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [StringLength(15)]
    public string? RoutingStatusCode { get; set; }

    public string? FinalComments { get; set; }

    public string? ErrorText { get; set; }

    [Column("PreviousRoutingInstanceHistoryGUID")]
    public Guid? PreviousRoutingInstanceHistoryGuid { get; set; }

    [Column("XMLData", TypeName = "ntext")]
    public string? Xmldata { get; set; }

    public int RowVersion { get; set; }

    public Guid RoutingGuid { get; set; }

    [StringLength(125)]
    public string? OriginatorFullName { get; set; }

    [StringLength(125)]
    public string? SubjectFullName { get; set; }

    [StringLength(128)]
    public string? FinalResponseBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinalResponseDateTime { get; set; }

    [ForeignKey("RoutingGuid")]
    [InverseProperty("UsysRoutingInstanceHistories")]
    public virtual UsysRouting Routing { get; set; } = null!;

    [ForeignKey("RoutingStatusCode")]
    [InverseProperty("UsysRoutingInstanceHistories")]
    public virtual UsysRoutingStatus? RoutingStatusCodeNavigation { get; set; }

    [InverseProperty("RoutingInstanceHistory")]
    public virtual ICollection<UsysRoutingInstanceStepHistory> UsysRoutingInstanceStepHistories { get; set; } = new List<UsysRoutingInstanceStepHistory>();
}
