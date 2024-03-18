using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingStep")]
public partial class UsysRoutingStep
{
    [Key]
    [Column("RoutingStepGUID")]
    public Guid RoutingStepGuid { get; set; }

    public int StepNumber { get; set; }

    public bool? FinalNotificationFlag { get; set; }

    [Column("RoutingStepGroupGUID")]
    public Guid RoutingStepGroupGuid { get; set; }

    public bool SuppressEmailFlag { get; set; }

    public int RowVersion { get; set; }

    public bool EditInPlaceFlag { get; set; }

    [Column("RecipientGUID")]
    public Guid RecipientGuid { get; set; }

    [StringLength(15)]
    public string RecipientTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string? RuleSetCode { get; set; }

    [ForeignKey("RecipientGuid")]
    [InverseProperty("UsysRoutingSteps")]
    public virtual UsysRecipient Recipient { get; set; } = null!;

    [ForeignKey("RecipientTypeCode")]
    [InverseProperty("UsysRoutingSteps")]
    public virtual UsysRecipientType RecipientTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("RoutingStepGroupGuid")]
    [InverseProperty("UsysRoutingSteps")]
    public virtual UsysRoutingStepGroup RoutingStepGroup { get; set; } = null!;

    [ForeignKey("RuleSetCode")]
    [InverseProperty("UsysRoutingSteps")]
    public virtual UsysRuleSet? RuleSetCodeNavigation { get; set; }

    [InverseProperty("RoutingStep")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceSteps { get; set; } = new List<UsysRoutingInstanceStep>();
}
