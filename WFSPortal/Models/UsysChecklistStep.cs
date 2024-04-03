using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysChecklistStep")]
public partial class UsysChecklistStep
{
    [Key]
    [Column("ChecklistStepGUID")]
    public Guid ChecklistStepGuid { get; set; }

    [StringLength(15)]
    public string ChecklistCode { get; set; } = null!;

    public int SortOrder { get; set; }

    [StringLength(50)]
    public string? TaskEntityName { get; set; }

    [StringLength(15)]
    public string? EmploymentDocumentCode { get; set; }

    [Column("RecipientGUID")]
    public Guid? RecipientGuid { get; set; }

    public int? NumberOfDays { get; set; }

    public int RowVersion { get; set; }

    public byte[]? ChecklistStepIconImage { get; set; }

    public bool OpenEnrollmentGroupFlag { get; set; }

    public string? ChecklistStepName { get; set; }

    [ForeignKey("ChecklistCode")]
    [InverseProperty("UsysChecklistSteps")]
    public virtual UsysChecklist ChecklistCodeNavigation { get; set; } = null!;

    [ForeignKey("EmploymentDocumentCode")]
    [InverseProperty("UsysChecklistSteps")]
    public virtual TEmploymentDocument? EmploymentDocumentCodeNavigation { get; set; }

    [ForeignKey("RecipientGuid")]
    [InverseProperty("UsysChecklistSteps")]
    public virtual UsysRecipient? Recipient { get; set; }

    [ForeignKey("TaskEntityName")]
    [InverseProperty("UsysChecklistSteps")]
    public virtual UsysEntity? TaskEntityNameNavigation { get; set; }

    [InverseProperty("ChecklistStep")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();
}
