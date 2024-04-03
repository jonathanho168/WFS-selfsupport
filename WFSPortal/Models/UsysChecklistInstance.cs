using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysChecklistInstance")]
[Index("SubjectPersonGuid", "GrantTabFlag", "EffectiveDate", Name = "WFS_USysChecklistInstance_SubjectPersonGUID_GrantTabFlag_EffectiveDate")]
public partial class UsysChecklistInstance
{
    [Key]
    [Column("ChecklistInstanceGUID")]
    public Guid ChecklistInstanceGuid { get; set; }

    [Column("SubjectPersonGUID")]
    public Guid? SubjectPersonGuid { get; set; }

    [Column("OwnerPersonGUID")]
    public Guid? OwnerPersonGuid { get; set; }

    [StringLength(15)]
    public string? ChecklistCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDate { get; set; }

    [Column("ClosedByPersonGUID")]
    public Guid? ClosedByPersonGuid { get; set; }

    public int RowVersion { get; set; }

    public bool GrantTabFlag { get; set; }

    public string? Description { get; set; }

    [ForeignKey("ChecklistCode")]
    [InverseProperty("UsysChecklistInstances")]
    public virtual UsysChecklist? ChecklistCodeNavigation { get; set; }

    [ForeignKey("ClosedByPersonGuid")]
    [InverseProperty("UsysChecklistInstanceClosedByPeople")]
    public virtual TPerson? ClosedByPerson { get; set; }

    [ForeignKey("OwnerPersonGuid")]
    [InverseProperty("UsysChecklistInstanceOwnerPeople")]
    public virtual TPerson? OwnerPerson { get; set; }

    [ForeignKey("SubjectPersonGuid")]
    [InverseProperty("UsysChecklistInstanceSubjectPeople")]
    public virtual TPerson? SubjectPerson { get; set; }

    [InverseProperty("ChecklistInstance")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();
}
