using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRuleSet")]
public partial class UsysRuleSet
{
    [Key]
    [StringLength(15)]
    public string RuleSetCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("RuleSetGUID")]
    public Guid RuleSetGuid { get; set; }

    public int RowVersion { get; set; }

    public string? RuleSetDescription { get; set; }

    [InverseProperty("RuleSetCodeNavigation")]
    public virtual ICollection<TPerformanceQuestion> TPerformanceQuestions { get; set; } = new List<TPerformanceQuestion>();

    [InverseProperty("RuleSetCodeNavigation")]
    public virtual ICollection<UsysRoutingStepGroup> UsysRoutingStepGroups { get; set; } = new List<UsysRoutingStepGroup>();

    [InverseProperty("RuleSetCodeNavigation")]
    public virtual ICollection<UsysRoutingStep> UsysRoutingSteps { get; set; } = new List<UsysRoutingStep>();

    [InverseProperty("RuleSetCodeNavigation")]
    public virtual ICollection<UsysRuleSetRule> UsysRuleSetRules { get; set; } = new List<UsysRuleSetRule>();
}
