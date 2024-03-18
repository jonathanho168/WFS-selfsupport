using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePlan")]
[Index("AbsencePlanGuid", Name = "RG_tAbsencePlan", IsUnique = true)]
public partial class TAbsencePlan
{
    [Key]
    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [Column("AbsencePlanGUID")]
    public Guid AbsencePlanGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string AccrualsFunction { get; set; } = null!;

    public bool AllowPastTimeOffRequestFlag { get; set; }

    public string? AbsencePlanDescription { get; set; }

    [Column("AllowExportToERPFlag")]
    public bool AllowExportToErpflag { get; set; }

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TAbsencePlanDetailHist> TAbsencePlanDetailHists { get; set; } = new List<TAbsencePlanDetailHist>();

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TAbsencePlanRuleSetHist> TAbsencePlanRuleSetHists { get; set; } = new List<TAbsencePlanRuleSetHist>();

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TPersonAbsenceEligibility> TPersonAbsenceEligibilities { get; set; } = new List<TPersonAbsenceEligibility>();

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TPersonAbsencePlan> TPersonAbsencePlans { get; set; } = new List<TPersonAbsencePlan>();

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupPeriodOvertime> TPersonTimeGroupPeriodOvertimes { get; set; } = new List<TPersonTimeGroupPeriodOvertime>();

    [InverseProperty("AbsencePlanCodeNavigation")]
    public virtual ICollection<TTimeType> TTimeTypes { get; set; } = new List<TTimeType>();
}
