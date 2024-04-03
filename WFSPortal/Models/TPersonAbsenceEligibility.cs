using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsenceEligibility")]
[Index("PersonGuid", "AbsencePlanCode", "AbsencePlanRuleGuid", Name = "AK_tPersonAbsenceEligibility", IsUnique = true)]
public partial class TPersonAbsenceEligibility
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string AbsencePlanCode { get; set; } = null!;

    [Column("AbsencePlanRuleGUID")]
    public Guid AbsencePlanRuleGuid { get; set; }

    public bool EligibilityBeginFlag { get; set; }

    public bool EligibilityEndFlag { get; set; }

    public bool FinalEligibilityBeginFlag { get; set; }

    public bool FinalEligibilityEndFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodBeginDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodEndDate { get; set; }

    [Key]
    [Column("PersonAbsenceEligibilityGUID")]
    public Guid PersonAbsenceEligibilityGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("AbsencePlanCode")]
    [InverseProperty("TPersonAbsenceEligibilities")]
    public virtual TAbsencePlan AbsencePlanCodeNavigation { get; set; } = null!;

    [ForeignKey("AbsencePlanRuleGuid")]
    [InverseProperty("TPersonAbsenceEligibilities")]
    public virtual TAbsencePlanRule AbsencePlanRule { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonAbsenceEligibilities")]
    public virtual TPerson Person { get; set; } = null!;
}
