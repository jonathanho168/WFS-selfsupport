using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsencePlanRuleSetHist")]
public partial class TAbsencePlanRuleSetHist
{
    [Key]
    [Column("AbsencePlanRuleSetGUID")]
    public Guid AbsencePlanRuleSetGuid { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [StringLength(15)]
    public string AbsenceRuleSetCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AbsencePlanRuleSetStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AbsencePlanRuleSetEndDate { get; set; }

    public bool InactiveFlag { get; set; }

    public int? MaxNumberofRequestsAllowed { get; set; }

    public string? AbsencePlanRuleSetDescription { get; set; }

    public int RowVersion { get; set; }

    public bool AbsencePlanRuleCurrentFlag { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TAbsencePlanRuleSetHists")]
    public virtual TAbsencePlan AbsencePlanCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsenceRuleSetCode")]
    [InverseProperty("TAbsencePlanRuleSetHists")]
    public virtual TAbsenceRuleSet AbsenceRuleSetCodeNavigation { get; set; } = null!;
}
