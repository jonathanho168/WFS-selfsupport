using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom3")]
[Index("Custom3Guid", Name = "RG_tCustom3", IsUnique = true)]
public partial class TCustom3
{
    [Key]
    [StringLength(15)]
    public string Custom3Code { get; set; } = null!;

    [Column("Custom3GUID")]
    public Guid Custom3Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom3Description { get; set; }

    [InverseProperty("Custom3CodeNavigation")]
    public virtual ICollection<TPersonCustomBase> TPersonCustomBases { get; set; } = new List<TPersonCustomBase>();
}
