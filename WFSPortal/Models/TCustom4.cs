using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom4")]
[Index("Custom4Guid", Name = "RG_tCustom4", IsUnique = true)]
public partial class TCustom4
{
    [Key]
    [StringLength(15)]
    public string Custom4Code { get; set; } = null!;

    [Column("Custom4GUID")]
    public Guid Custom4Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom4Description { get; set; }

    [InverseProperty("Custom4CodeNavigation")]
    public virtual ICollection<TPersonCustomBase> TPersonCustomBases { get; set; } = new List<TPersonCustomBase>();
}
