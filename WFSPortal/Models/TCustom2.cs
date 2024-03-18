using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom2")]
[Index("Custom2Guid", Name = "RG_tCustom2", IsUnique = true)]
public partial class TCustom2
{
    [Key]
    [StringLength(15)]
    public string Custom2Code { get; set; } = null!;

    [Column("Custom2GUID")]
    public Guid Custom2Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom2Description { get; set; }

    [InverseProperty("Custom2CodeNavigation")]
    public virtual ICollection<TPersonCustomBase> TPersonCustomBases { get; set; } = new List<TPersonCustomBase>();
}
