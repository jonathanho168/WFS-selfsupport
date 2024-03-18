using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingInstanceStepHistory")]
public partial class UsysRoutingInstanceStepHistory
{
    [Key]
    [Column("RoutingInstanceStepHistoryGUID")]
    public Guid RoutingInstanceStepHistoryGuid { get; set; }

    [Column("RoutingInstanceHistoryGUID")]
    public Guid RoutingInstanceHistoryGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InitiatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResponseDateTime { get; set; }

    [StringLength(15)]
    public string? RoutingResponseCode { get; set; }

    public string? Comments { get; set; }

    [StringLength(125)]
    public string? RecipientFullName { get; set; }

    [StringLength(80)]
    public string? RecipientDescription { get; set; }

    [StringLength(15)]
    public string? RecipientTypeCode { get; set; }

    [StringLength(125)]
    public string? SignedByPersonFullName { get; set; }

    public int RowVersion { get; set; }

    public int? StepNumber { get; set; }

    [Column("XMLData", TypeName = "ntext")]
    public string? Xmldata { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    [StringLength(256)]
    public string? ProxyUserName { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysRoutingInstanceStepHistories")]
    public virtual UsysPortal? Portal { get; set; }

    [ForeignKey("RoutingInstanceHistoryGuid")]
    [InverseProperty("UsysRoutingInstanceStepHistories")]
    public virtual UsysRoutingInstanceHistory RoutingInstanceHistory { get; set; } = null!;

    [ForeignKey("RoutingResponseCode")]
    [InverseProperty("UsysRoutingInstanceStepHistories")]
    public virtual UsysRoutingResponse? RoutingResponseCodeNavigation { get; set; }
}
