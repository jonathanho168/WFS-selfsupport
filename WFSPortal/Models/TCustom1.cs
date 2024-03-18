using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom1")]
[Index("Custom1Guid", Name = "RG_tCustom1", IsUnique = true)]
public partial class TCustom1
{
    [Key]
    [StringLength(15)]
    public string Custom1Code { get; set; } = null!;

    [Column("Custom1GUID")]
    public Guid Custom1Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom1Description { get; set; }

    [InverseProperty("Custom1CodeNavigation")]
    public virtual ICollection<TPersonCustomBase> TPersonCustomBases { get; set; } = new List<TPersonCustomBase>();
}
