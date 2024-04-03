using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingStepGroup")]
public partial class UsysRoutingStepGroup
{
    [Key]
    [Column("RoutingStepGroupGUID")]
    public Guid RoutingStepGroupGuid { get; set; }

    public int SortOrder { get; set; }

    public int RowVersion { get; set; }

    public Guid RoutingGuid { get; set; }

    [StringLength(15)]
    public string? RuleSetCode { get; set; }

    public string? RoutingStepGroupDescription { get; set; }

    [ForeignKey("RoutingGuid")]
    [InverseProperty("UsysRoutingStepGroups")]
    public virtual UsysRouting Routing { get; set; } = null!;

    [ForeignKey("RuleSetCode")]
    [InverseProperty("UsysRoutingStepGroups")]
    public virtual UsysRuleSet? RuleSetCodeNavigation { get; set; }

    [InverseProperty("RoutingStepGroup")]
    public virtual ICollection<UsysRoutingInstance> UsysRoutingInstances { get; set; } = new List<UsysRoutingInstance>();

    [InverseProperty("RoutingStepGroup")]
    public virtual ICollection<UsysRoutingStep> UsysRoutingSteps { get; set; } = new List<UsysRoutingStep>();
}
