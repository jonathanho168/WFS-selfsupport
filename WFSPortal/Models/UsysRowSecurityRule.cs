using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRowSecurityRule")]
[Index("RowSecurityRuleGuid", Name = "RG_USysRowSecurityRule", IsUnique = true)]
public partial class UsysRowSecurityRule
{
    [Column("RowSecurityRuleGUID")]
    public Guid RowSecurityRuleGuid { get; set; }

    [Key]
    [StringLength(80)]
    public string RowSecurityRuleName { get; set; } = null!;

    [Column("RowSecurityRuleSQL")]
    [StringLength(4000)]
    public string RowSecurityRuleSql { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public string? RowSecurityRuleDescription { get; set; }

    [InverseProperty("RowSecurityRuleNameNavigation")]
    public virtual ICollection<UsysLnkExportGroupRule> UsysLnkExportGroupRules { get; set; } = new List<UsysLnkExportGroupRule>();

    [InverseProperty("RowSecurityRuleNameNavigation")]
    public virtual ICollection<UsysQueryBuilderQuery> UsysQueryBuilderQueries { get; set; } = new List<UsysQueryBuilderQuery>();

    [InverseProperty("RowSecurityRuleNameNavigation")]
    public virtual ICollection<UsysRoleRule> UsysRoleRules { get; set; } = new List<UsysRoleRule>();
}
