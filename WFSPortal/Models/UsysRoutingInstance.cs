using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingInstance")]
[Index("OriginatorPersonGuid", Name = "IX_USysRoutingInstance_OriginatorPerson")]
[Index("PreviousRoutingInstanceGuid", Name = "IX_USysRoutingInstance_PreviousRoutingInstanceGUID")]
[Index("SubjectPersonGuid", Name = "IX_USysRoutingInstance_SubjectPerson")]
[Index("RoutingStatusCode", "TaskDraftGuid", Name = "WFS_USysRoutingInstance_RoutingStatusCode_TaskDraftGuid")]
public partial class UsysRoutingInstance
{
    [Key]
    [Column("RoutingInstanceGUID")]
    public Guid RoutingInstanceGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [Column("OriginatorPersonGUID")]
    public Guid? OriginatorPersonGuid { get; set; }

    [Column("SubjectPersonGUID")]
    public Guid? SubjectPersonGuid { get; set; }

    [StringLength(15)]
    public string? RoutingStatusCode { get; set; }

    public string? FinalComments { get; set; }

    public string? ErrorText { get; set; }

    [Column("PreviousRoutingInstanceGUID")]
    public Guid? PreviousRoutingInstanceGuid { get; set; }

    [Column("RoutingStepGroupGUID")]
    public Guid? RoutingStepGroupGuid { get; set; }

    [Column("XMLData", TypeName = "xml")]
    public string? Xmldata { get; set; }

    public int RowVersion { get; set; }

    public Guid RoutingGuid { get; set; }

    public Guid TaskDraftGuid { get; set; }

    [Column(TypeName = "xml")]
    public string? SavedXmlData { get; set; }

    [InverseProperty("PreviousRoutingInstance")]
    public virtual ICollection<UsysRoutingInstance> InversePreviousRoutingInstance { get; set; } = new List<UsysRoutingInstance>();

    [ForeignKey("OriginatorPersonGuid")]
    [InverseProperty("UsysRoutingInstanceOriginatorPeople")]
    public virtual TPerson? OriginatorPerson { get; set; }

    [ForeignKey("PreviousRoutingInstanceGuid")]
    [InverseProperty("InversePreviousRoutingInstance")]
    public virtual UsysRoutingInstance? PreviousRoutingInstance { get; set; }

    [ForeignKey("RoutingGuid")]
    [InverseProperty("UsysRoutingInstances")]
    public virtual UsysRouting Routing { get; set; } = null!;

    [ForeignKey("RoutingStatusCode")]
    [InverseProperty("UsysRoutingInstances")]
    public virtual UsysRoutingStatus? RoutingStatusCodeNavigation { get; set; }

    [ForeignKey("RoutingStepGroupGuid")]
    [InverseProperty("UsysRoutingInstances")]
    public virtual UsysRoutingStepGroup? RoutingStepGroup { get; set; }

    [ForeignKey("SubjectPersonGuid")]
    [InverseProperty("UsysRoutingInstanceSubjectPeople")]
    public virtual TPerson? SubjectPerson { get; set; }

    [InverseProperty("RoutingInstance")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();

    [InverseProperty("RoutingInstance")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceSteps { get; set; } = new List<UsysRoutingInstanceStep>();
}
