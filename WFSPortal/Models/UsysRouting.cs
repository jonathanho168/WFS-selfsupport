using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRouting")]
public partial class UsysRouting
{
    [StringLength(50)]
    public string RouteName { get; set; } = null!;

    public bool ActiveFlag { get; set; }

    [Key]
    [Column("RoutingGUID")]
    public Guid RoutingGuid { get; set; }

    public bool AllowResubmitFlag { get; set; }

    public bool SignatureEnabledFlag { get; set; }

    public int RowVersion { get; set; }

    public bool SkipOriginatorFlag { get; set; }

    public int? IdleNotifyDays { get; set; }

    [StringLength(50)]
    public string? TaskEntity { get; set; }

    public bool SaveOnSubmitFlag { get; set; }

    [StringLength(256)]
    public string? ControlPathFileName { get; set; }

    [StringLength(256)]
    public string? PrintControlPathFileName { get; set; }

    public string? RoutingDescription { get; set; }

    [ForeignKey("TaskEntity")]
    [InverseProperty("UsysRouting")]
    public virtual UsysEntity? TaskEntityNavigation { get; set; }

    [InverseProperty("Routing")]
    public virtual ICollection<UsysRoutingInstanceHistory> UsysRoutingInstanceHistories { get; set; } = new List<UsysRoutingInstanceHistory>();

    [InverseProperty("Routing")]
    public virtual ICollection<UsysRoutingInstance> UsysRoutingInstances { get; set; } = new List<UsysRoutingInstance>();

    [InverseProperty("Routing")]
    public virtual ICollection<UsysRoutingStepGroup> UsysRoutingStepGroups { get; set; } = new List<UsysRoutingStepGroup>();
}
