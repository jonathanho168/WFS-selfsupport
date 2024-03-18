using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRecipient")]
[Index("RecipientCode", Name = "AK_USysRecipientCode", IsUnique = true)]
[Index("RecipientPersonGuid", Name = "IX_USysRecipient_RecipientPerson")]
public partial class UsysRecipient
{
    [StringLength(15)]
    public string RecipientCode { get; set; } = null!;

    [Column("RecipientPersonGUID")]
    public Guid? RecipientPersonGuid { get; set; }

    [StringLength(15)]
    public string? RecipientPositionCode { get; set; }

    public bool? SystemFlag { get; set; }

    [Key]
    public Guid RecipientGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string RecipientDesignatorCode { get; set; } = null!;

    [StringLength(255)]
    public string? RecipientCalculationClass { get; set; }

    public string? RecipientDescription { get; set; }

    [ForeignKey("RecipientDesignatorCode")]
    [InverseProperty("UsysRecipients")]
    public virtual UsysRecipientDesignator RecipientDesignatorCodeNavigation { get; set; } = null!;

    [ForeignKey("RecipientPersonGuid")]
    [InverseProperty("UsysRecipients")]
    public virtual TPerson? RecipientPerson { get; set; }

    [ForeignKey("RecipientPositionCode")]
    [InverseProperty("UsysRecipients")]
    public virtual TPosition? RecipientPositionCodeNavigation { get; set; }

    [InverseProperty("Recipient")]
    public virtual ICollection<TAbsenceRuleSetCommunicationRecipient> TAbsenceRuleSetCommunicationRecipients { get; set; } = new List<TAbsenceRuleSetCommunicationRecipient>();

    [InverseProperty("Recipient")]
    public virtual ICollection<UsysAlertRecipient> UsysAlertRecipients { get; set; } = new List<UsysAlertRecipient>();

    [InverseProperty("Recipient")]
    public virtual ICollection<UsysAlertScheduleRecipient> UsysAlertScheduleRecipients { get; set; } = new List<UsysAlertScheduleRecipient>();

    [InverseProperty("OwnerRecipient")]
    public virtual ICollection<UsysChecklist> UsysChecklistOwnerRecipients { get; set; } = new List<UsysChecklist>();

    [InverseProperty("Recipient")]
    public virtual ICollection<UsysChecklistStep> UsysChecklistSteps { get; set; } = new List<UsysChecklistStep>();

    [InverseProperty("SubjectRecipient")]
    public virtual ICollection<UsysChecklist> UsysChecklistSubjectRecipients { get; set; } = new List<UsysChecklist>();

    [InverseProperty("Recipient")]
    public virtual ICollection<UsysRoutingStep> UsysRoutingSteps { get; set; } = new List<UsysRoutingStep>();
}
