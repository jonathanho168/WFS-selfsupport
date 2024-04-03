using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VWfsopenRoute
{
    [Column("RoutingInstanceGUID")]
    public Guid RoutingInstanceGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [StringLength(50)]
    public string? RouteName { get; set; }

    [Column("RoutingGUID")]
    public Guid? RoutingGuid { get; set; }

    [StringLength(152)]
    public string? Submitter { get; set; }

    [Column("SubmitterGUID")]
    public Guid? SubmitterGuid { get; set; }

    [StringLength(152)]
    public string? Subject { get; set; }

    [Column("SubjectGUID")]
    public Guid? SubjectGuid { get; set; }

    public string? Status { get; set; }

    public string FinalComments { get; set; } = null!;

    public string ErrorText { get; set; } = null!;

    [Column("PreviousRoutingInstanceGUID")]
    public Guid PreviousRoutingInstanceGuid { get; set; }

    [Column("RoutingStepGroupGUID")]
    public Guid? RoutingStepGroupGuid { get; set; }

    [Column("XMLData", TypeName = "xml")]
    public string? Xmldata { get; set; }

    public int? StepNumber { get; set; }

    [Column("Route Recipient")]
    [StringLength(152)]
    public string? RouteRecipient { get; set; }

    [Column("Route Recipient GUID")]
    public Guid? RouteRecipientGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InitiatedDateTime { get; set; }

    [Column("Allow Edit")]
    public bool? AllowEdit { get; set; }

    [Column("Route Type")]
    public string? RouteType { get; set; }

    public string? Response { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ResponseDateTime { get; set; }

    [Column("comments")]
    public string Comments { get; set; } = null!;

    [Column("Signed By")]
    [StringLength(152)]
    public string? SignedBy { get; set; }
}
