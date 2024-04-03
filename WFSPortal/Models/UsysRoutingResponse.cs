using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysRoutingResponse")]
[Index("RoutingResponseGuid", Name = "RG_USysRoutingResponse", IsUnique = true)]
public partial class UsysRoutingResponse
{
    [Key]
    [StringLength(15)]
    public string RoutingResponseCode { get; set; } = null!;

    [Column("RoutingResponseGUID")]
    public Guid RoutingResponseGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RoutingResponseDescription { get; set; }

    [InverseProperty("RoutingResponseCodeNavigation")]
    public virtual ICollection<UsysRoutingInstanceStepHistory> UsysRoutingInstanceStepHistories { get; set; } = new List<UsysRoutingInstanceStepHistory>();

    [InverseProperty("RoutingResponseCodeNavigation")]
    public virtual ICollection<UsysRoutingInstanceStep> UsysRoutingInstanceSteps { get; set; } = new List<UsysRoutingInstanceStep>();
}
