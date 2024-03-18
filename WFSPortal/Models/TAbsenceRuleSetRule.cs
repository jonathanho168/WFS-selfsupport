using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceRuleSetRule")]
public partial class TAbsenceRuleSetRule
{
    [Key]
    [Column("AbsenceRuleSetRuleGUID")]
    public Guid AbsenceRuleSetRuleGuid { get; set; }

    [StringLength(15)]
    public string AbsenceRuleSetCode { get; set; } = null!;

    [StringLength(15)]
    public string AbsenceRuleCode { get; set; } = null!;

    public int RowVersion { get; set; }

    [ForeignKey("AbsenceRuleCode")]
    [InverseProperty("TAbsenceRuleSetRules")]
    public virtual TAbsenceRule AbsenceRuleCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsenceRuleSetCode")]
    [InverseProperty("TAbsenceRuleSetRules")]
    public virtual TAbsenceRuleSet AbsenceRuleSetCodeNavigation { get; set; } = null!;
}
