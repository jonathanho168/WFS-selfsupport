using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysChecklistInstanceStep")]
[Index("PersonGuid", Name = "IX_USysChecklistInstanceStep_PersonGUID")]
public partial class UsysChecklistInstanceStep
{
    [Key]
    [Column("ChecklistInstanceStepGUID")]
    public Guid ChecklistInstanceStepGuid { get; set; }

    [Column("ChecklistInstanceGUID")]
    public Guid ChecklistInstanceGuid { get; set; }

    public int SortOrder { get; set; }

    [StringLength(50)]
    public string? TaskEntityName { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDate { get; set; }

    [Column("RoutingInstanceGUID")]
    public Guid? RoutingInstanceGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("ChecklistStepGUID")]
    public Guid? ChecklistStepGuid { get; set; }

    [StringLength(255)]
    public string ChecklistInstanceStepName { get; set; } = null!;

    public byte[]? ChecklistInstanceStepIconImage { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PersonEmploymentDocumentGUID")]
    public Guid? PersonEmploymentDocumentGuid { get; set; }

    [Column("PersonFutureEnrollmentStatusGUID")]
    public Guid? PersonFutureEnrollmentStatusGuid { get; set; }

    [ForeignKey("ChecklistInstanceGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual UsysChecklistInstance ChecklistInstance { get; set; } = null!;

    [ForeignKey("ChecklistStepGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual UsysChecklistStep? ChecklistStep { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonEmploymentDocumentGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual TPersonEmploymentDocument? PersonEmploymentDocument { get; set; }

    [ForeignKey("PersonFutureEnrollmentStatusGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual TPersonFutureEnrollmentStatus? PersonFutureEnrollmentStatus { get; set; }

    [ForeignKey("RoutingInstanceGuid")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual UsysRoutingInstance? RoutingInstance { get; set; }

    [ForeignKey("TaskEntityName")]
    [InverseProperty("UsysChecklistInstanceSteps")]
    public virtual UsysEntity? TaskEntityNameNavigation { get; set; }
}
