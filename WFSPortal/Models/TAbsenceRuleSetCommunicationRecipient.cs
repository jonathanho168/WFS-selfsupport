using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceRuleSetCommunicationRecipient")]
public partial class TAbsenceRuleSetCommunicationRecipient
{
    [Key]
    [Column("AbsenceRuleSetCommunicationRecipientGUID")]
    public Guid AbsenceRuleSetCommunicationRecipientGuid { get; set; }

    [StringLength(15)]
    public string AbsenceRuleSetCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public Guid RecipientGuid { get; set; }

    [ForeignKey("AbsenceRuleSetCode")]
    [InverseProperty("TAbsenceRuleSetCommunicationRecipients")]
    public virtual TAbsenceRuleSet AbsenceRuleSetCodeNavigation { get; set; } = null!;

    [ForeignKey("RecipientGuid")]
    [InverseProperty("TAbsenceRuleSetCommunicationRecipients")]
    public virtual UsysRecipient Recipient { get; set; } = null!;
}
