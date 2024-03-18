using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tMobilityStatus")]
[Index("MobilityStatusGuid", Name = "RG_tMobilityStatus", IsUnique = true)]
public partial class TMobilityStatus
{
    [Key]
    [StringLength(15)]
    public string MobilityStatusCode { get; set; } = null!;

    [Column("MobilityStatusGUID")]
    public Guid MobilityStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? MobilityStatusDescription { get; set; }

    [InverseProperty("MobilityStatusCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();
}
