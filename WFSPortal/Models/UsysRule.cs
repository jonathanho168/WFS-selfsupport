using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRule")]
[Index("EntityName", Name = "IX_USysRule_EntityName")]
public partial class UsysRule
{
    [Key]
    [StringLength(15)]
    public string RuleCode { get; set; } = null!;

    [Column("SQL")]
    [StringLength(4000)]
    public string? Sql { get; set; }

    [StringLength(50)]
    public string? EntityName { get; set; }

    [StringLength(128)]
    public string? ColumnOrEntityFieldName { get; set; }

    [StringLength(20)]
    public string DataType { get; set; } = null!;

    [StringLength(6)]
    public string ComparisonOperator { get; set; } = null!;

    [StringLength(4000)]
    public string Value { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("RuleGUID")]
    public Guid RuleGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Context { get; set; }

    public string? RuleDescription { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("UsysRules")]
    public virtual UsysEntity? EntityNameNavigation { get; set; }

    [InverseProperty("RuleCodeNavigation")]
    public virtual ICollection<UsysRuleSetRule> UsysRuleSetRules { get; set; } = new List<UsysRuleSetRule>();
}
