using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePlanRule")]
public partial class TAbsencePlanRule
{
    [Key]
    [Column("AbsencePlanRuleGUID")]
    public Guid AbsencePlanRuleGuid { get; set; }

    [Column("AbsencePlanDetailGUID")]
    public Guid AbsencePlanDetailGuid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AccrualRate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CarryOver { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal EligibilityRuleBeginValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal EligibilityRuleEndValue { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? MaximumAccrual { get; set; }

    [StringLength(15)]
    public string ServiceUnits { get; set; } = null!;

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string? EligibilityRuleProcedure { get; set; }

    [ForeignKey("AbsencePlanDetailGuid")]
    [InverseProperty("TAbsencePlanRules")]
    public virtual TAbsencePlanDetailHist AbsencePlanDetail { get; set; } = null!;

    [InverseProperty("AbsencePlanRule")]
    public virtual ICollection<TPersonAbsenceEligibility> TPersonAbsenceEligibilities { get; set; } = new List<TPersonAbsenceEligibility>();
}
