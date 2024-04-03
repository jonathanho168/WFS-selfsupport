using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAlertRecipient")]
public partial class UsysAlertRecipient
{
    [Key]
    [Column("AlertRecipientGUID")]
    public Guid AlertRecipientGuid { get; set; }

    public int RowVersion { get; set; }

    public Guid? RecipientGuid { get; set; }

    [Column("AlertGUID")]
    public Guid AlertGuid { get; set; }

    [ForeignKey("AlertGuid")]
    [InverseProperty("UsysAlertRecipients")]
    public virtual UsysAlert Alert { get; set; } = null!;

    [ForeignKey("RecipientGuid")]
    [InverseProperty("UsysAlertRecipients")]
    public virtual UsysRecipient? Recipient { get; set; }
}
