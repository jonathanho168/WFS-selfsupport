using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEmploymentDocument")]
public partial class TEmploymentDocument
{
    [Key]
    [StringLength(15)]
    public string EmploymentDocumentCode { get; set; } = null!;

    public int? DaysToReadBy { get; set; }

    public byte[]? Document { get; set; }

    public Guid? ModuleDefGuid { get; set; }

    public bool RequiresElectronicSignature { get; set; }

    public bool DefaultToNewHireFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public Guid EmploymentDocumentGuid { get; set; }

    public int RowVersion { get; set; }

    public string? EmploymentDocumentDescription { get; set; }

    public int? ScheduledReadRequiredIntervalTime { get; set; }

    [StringLength(15)]
    public string? ScheduledReadRequiredIntervalTimeUnit { get; set; }

    public bool ScheduledReadRequiredNotifyEmployeeFlag { get; set; }

    [InverseProperty("EmploymentDocumentCodeNavigation")]
    public virtual ICollection<TPersonEmploymentDocument> TPersonEmploymentDocuments { get; set; } = new List<TPersonEmploymentDocument>();

    [InverseProperty("EmploymentDocumentCodeNavigation")]
    public virtual ICollection<UsysChecklistStep> UsysChecklistSteps { get; set; } = new List<UsysChecklistStep>();
}
