using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceRuleSet")]
public partial class TAbsenceRuleSet
{
    [Key]
    [StringLength(15)]
    public string AbsenceRuleSetCode { get; set; } = null!;

    public string? AbsenceRuleSetDescription { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("CommunicationTemplateGUID")]
    public Guid? CommunicationTemplateGuid { get; set; }

    [Column("AbsenceRuleSetGUID")]
    public Guid AbsenceRuleSetGuid { get; set; }

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CommunicationTemplateGuid")]
    [InverseProperty("TAbsenceRuleSets")]
    public virtual UsysCommunicationTemplate? CommunicationTemplate { get; set; }

    [ForeignKey("CreatedByPersonGuid")]
    [InverseProperty("TAbsenceRuleSets")]
    public virtual TPerson? CreatedByPerson { get; set; }

    [InverseProperty("AbsenceRuleSetCodeNavigation")]
    public virtual ICollection<TAbsencePlanRuleSetHist> TAbsencePlanRuleSetHists { get; set; } = new List<TAbsencePlanRuleSetHist>();

    [InverseProperty("AbsenceRuleSetCodeNavigation")]
    public virtual ICollection<TAbsenceRuleSetCommunicationRecipient> TAbsenceRuleSetCommunicationRecipients { get; set; } = new List<TAbsenceRuleSetCommunicationRecipient>();

    [InverseProperty("AbsenceRuleSetCodeNavigation")]
    public virtual ICollection<TAbsenceRuleSetOwner> TAbsenceRuleSetOwners { get; set; } = new List<TAbsenceRuleSetOwner>();

    [InverseProperty("AbsenceRuleSetCodeNavigation")]
    public virtual ICollection<TAbsenceRuleSetRule> TAbsenceRuleSetRules { get; set; } = new List<TAbsenceRuleSetRule>();
}
