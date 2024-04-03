using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLifeEventStatus")]
[Index("LifeEventStatusGuid", Name = "RG_tLifeEventStatus", IsUnique = true)]
public partial class TLifeEventStatus
{
    [Key]
    [StringLength(15)]
    public string LifeEventStatusCode { get; set; } = null!;

    public bool ApprovedFlag { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("LifeEventStatusGUID")]
    public Guid LifeEventStatusGuid { get; set; }

    public int RowVersion { get; set; }

    public string? LifeEventStatusDescription { get; set; }

    [InverseProperty("LifeEventStatusCodeNavigation")]
    public virtual ICollection<TPersonLifeEvent> TPersonLifeEvents { get; set; } = new List<TPersonLifeEvent>();
}
