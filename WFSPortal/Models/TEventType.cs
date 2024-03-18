using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEventType")]
[Index("EventTypeGuid", Name = "RG_tEventType", IsUnique = true)]
public partial class TEventType
{
    [Key]
    [StringLength(15)]
    public string EventTypeCode { get; set; } = null!;

    [Column("EventTypeGUID")]
    public Guid EventTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? EventTypeDescription { get; set; }

    [InverseProperty("EventTypeCodeNavigation")]
    public virtual ICollection<TClassSchedule> TClassSchedules { get; set; } = new List<TClassSchedule>();
}
