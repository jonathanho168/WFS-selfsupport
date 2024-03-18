using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingInstanceStep")]
[Index("RecipientPersonGuid", Name = "IX_USysRoutingInstanceStep_RecipientPersonGUID")]
[Index("SignedByPersonGuid", Name = "IX_USysRoutingInstanceStep_SignedByPerson")]
public partial class UsysRoutingInstanceStep
{
    [Key]
    [Column("RoutingInstanceStepGUID")]
    public Guid RoutingInstanceStepGuid { get; set; }

    [Column("RoutingInstanceGUID")]
    public Guid RoutingInstanceGuid { get; set; }

    [Column("RoutingStepGUID")]
    public Guid RoutingStepGuid { get; set; }

    [Column("RecipientPersonGUID")]
    public Guid? RecipientPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InitiatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResponseDateTime { get; set; }

    [StringLength(15)]
    public string? RoutingResponseCode { get; set; }

    public string? Comments { get; set; }

    public int? StepNumber { get; set; }

    [Column("SignedByPersonGUID")]
    public Guid? SignedByPersonGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "xml")]
    public string? TaskXml { get; set; }

    [Column("PortalGUID")]
    public Guid? PortalGuid { get; set; }

    [StringLength(256)]
    public string? ProxyUserName { get; set; }

    [ForeignKey("PortalGuid")]
    [InverseProperty("UsysRoutingInstanceSteps")]
    public virtual UsysPortal? Portal { get; set; }

    [ForeignKey("RecipientPersonGuid")]
    [InverseProperty("UsysRoutingInstanceStepRecipientPeople")]
    public virtual TPerson? RecipientPerson { get; set; }

    [ForeignKey("RoutingInstanceGuid")]
    [InverseProperty("UsysRoutingInstanceSteps")]
    public virtual UsysRoutingInstance RoutingInstance { get; set; } = null!;

    [ForeignKey("RoutingResponseCode")]
    [InverseProperty("UsysRoutingInstanceSteps")]
    public virtual UsysRoutingResponse? RoutingResponseCodeNavigation { get; set; }

    [ForeignKey("RoutingStepGuid")]
    [InverseProperty("UsysRoutingInstanceSteps")]
    public virtual UsysRoutingStep RoutingStep { get; set; } = null!;

    [ForeignKey("SignedByPersonGuid")]
    [InverseProperty("UsysRoutingInstanceStepSignedByPeople")]
    public virtual TPerson? SignedByPerson { get; set; }
}
