using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingStatus")]
[Index("RoutingStatusGuid", Name = "RG_USysRoutingStatus", IsUnique = true)]
public partial class UsysRoutingStatus
{
    [Key]
    [StringLength(15)]
    public string RoutingStatusCode { get; set; } = null!;

    [Column("RoutingStatusGUID")]
    public Guid RoutingStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RoutingStatusDescription { get; set; }

    [InverseProperty("RoutingStatusCodeNavigation")]
    public virtual ICollection<UsysRoutingInstanceHistory> UsysRoutingInstanceHistories { get; set; } = new List<UsysRoutingInstanceHistory>();

    [InverseProperty("RoutingStatusCodeNavigation")]
    public virtual ICollection<UsysRoutingInstance> UsysRoutingInstances { get; set; } = new List<UsysRoutingInstance>();
}
