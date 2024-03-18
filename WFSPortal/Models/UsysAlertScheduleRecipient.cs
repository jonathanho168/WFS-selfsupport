using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAlertScheduleRecipient")]
[Index("AlertScheduleGuid", "RecipientGuid", Name = "AK_USysAlertScheduleRecipient", IsUnique = true)]
public partial class UsysAlertScheduleRecipient
{
    [Column("AlertScheduleGUID")]
    public Guid AlertScheduleGuid { get; set; }

    [Key]
    [Column("AlertScheduleRecipientGUID")]
    public Guid AlertScheduleRecipientGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("RecipientGUID")]
    public Guid RecipientGuid { get; set; }

    [ForeignKey("AlertScheduleGuid")]
    [InverseProperty("UsysAlertScheduleRecipients")]
    public virtual UsysAlertSchedule AlertSchedule { get; set; } = null!;

    [ForeignKey("RecipientGuid")]
    [InverseProperty("UsysAlertScheduleRecipients")]
    public virtual UsysRecipient Recipient { get; set; } = null!;
}
