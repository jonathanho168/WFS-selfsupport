using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRuleSetRule")]
[Index("RuleCode", Name = "IX_USysRuleSetRule_RuleCode")]
[Index("RuleSetCode", Name = "IX_USysRuleSetRule_RuleSetCode")]
public partial class UsysRuleSetRule
{
    [Key]
    [Column("RuleSetRuleGUID")]
    public Guid RuleSetRuleGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string? RuleSetCode { get; set; }

    [StringLength(15)]
    public string? RuleCode { get; set; }

    [ForeignKey("RuleCode")]
    [InverseProperty("UsysRuleSetRules")]
    public virtual UsysRule? RuleCodeNavigation { get; set; }

    [ForeignKey("RuleSetCode")]
    [InverseProperty("UsysRuleSetRules")]
    public virtual UsysRuleSet? RuleSetCodeNavigation { get; set; }
}
