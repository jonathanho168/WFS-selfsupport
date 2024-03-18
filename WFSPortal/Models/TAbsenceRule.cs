using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceRule")]
public partial class TAbsenceRule
{
    [Key]
    [StringLength(15)]
    public string AbsenceRuleCode { get; set; } = null!;

    public string? AbsenceRuleDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(50)]
    public string EntityName { get; set; } = null!;

    [StringLength(128)]
    public string? ColumnFieldName { get; set; }

    [StringLength(6)]
    public string ComparisonOperator { get; set; } = null!;

    [StringLength(4000)]
    public string Value { get; set; } = null!;

    [Column("AbsenceRuleGUID")]
    public Guid AbsenceRuleGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("EntityName")]
    [InverseProperty("TAbsenceRules")]
    public virtual UsysEntity EntityNameNavigation { get; set; } = null!;

    [InverseProperty("AbsenceRuleCodeNavigation")]
    public virtual ICollection<TAbsenceRuleSetRule> TAbsenceRuleSetRules { get; set; } = new List<TAbsenceRuleSetRule>();
}
