using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tStatusGroup")]
[Index("StatusGroupGuid", Name = "RG_tStatusGroup", IsUnique = true)]
public partial class TStatusGroup
{
    [Key]
    [StringLength(15)]
    public string StatusGroupCode { get; set; } = null!;

    [Column("StatusGroupGUID")]
    public Guid StatusGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? StatusGroupDescription { get; set; }

    [InverseProperty("StatusGroupCodeNavigation")]
    public virtual ICollection<TStatus> TStatuses { get; set; } = new List<TStatus>();
}
