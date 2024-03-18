using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRecipientOverride")]
[Index("OriginalApproverGuid", Name = "IX_USysRecipientOverride_OriginalApprover")]
[Index("OverrideApproverGuid", Name = "IX_USysRecipientOverride_OverrideApprover")]
public partial class UsysRecipientOverride
{
    [Key]
    public Guid OverrideGuid { get; set; }

    public Guid OriginalApproverGuid { get; set; }

    public Guid OverrideApproverGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int RowVersion { get; set; }

    public bool? IsUpdate { get; set; }

    [StringLength(50)]
    public string? TaskEntity { get; set; }

    [ForeignKey("OriginalApproverGuid")]
    [InverseProperty("UsysRecipientOverrideOriginalApprovers")]
    public virtual TPerson OriginalApprover { get; set; } = null!;

    [ForeignKey("OverrideApproverGuid")]
    [InverseProperty("UsysRecipientOverrideOverrideApprovers")]
    public virtual TPerson OverrideApprover { get; set; } = null!;

    [ForeignKey("TaskEntity")]
    [InverseProperty("UsysRecipientOverrides")]
    public virtual UsysEntity? TaskEntityNavigation { get; set; }
}
