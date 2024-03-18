using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysChecklist")]
[Index("ChecklistGuid", Name = "AK_USysChecklist", IsUnique = true)]
public partial class UsysChecklist
{
    [Column("ChecklistGUID")]
    public Guid ChecklistGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string ChecklistCode { get; set; } = null!;

    [Column("SubjectRecipientGUID")]
    public Guid? SubjectRecipientGuid { get; set; }

    [Column("OwnerRecipientGUID")]
    public Guid? OwnerRecipientGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("ChecklistTabGUID")]
    public Guid? ChecklistTabGuid { get; set; }

    public int? ChecklistTabExpirationDays { get; set; }

    public bool UseForAlertFlag { get; set; }

    public string? ChecklistDescription { get; set; }

    [ForeignKey("ChecklistTabGuid")]
    [InverseProperty("UsysChecklists")]
    public virtual UsysTab? ChecklistTab { get; set; }

    [ForeignKey("OwnerRecipientGuid")]
    [InverseProperty("UsysChecklistOwnerRecipients")]
    public virtual UsysRecipient? OwnerRecipient { get; set; }

    [ForeignKey("SubjectRecipientGuid")]
    [InverseProperty("UsysChecklistSubjectRecipients")]
    public virtual UsysRecipient? SubjectRecipient { get; set; }

    [InverseProperty("ChecklistCodeNavigation")]
    public virtual ICollection<UsysChecklistInstance> UsysChecklistInstances { get; set; } = new List<UsysChecklistInstance>();

    [InverseProperty("ChecklistCodeNavigation")]
    public virtual ICollection<UsysChecklistStep> UsysChecklistSteps { get; set; } = new List<UsysChecklistStep>();
}
