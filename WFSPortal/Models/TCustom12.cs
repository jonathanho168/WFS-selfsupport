using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom12")]
[Index("Custom12Guid", Name = "RG_tCustom12", IsUnique = true)]
public partial class TCustom12
{
    [Key]
    [StringLength(15)]
    public string Custom12Code { get; set; } = null!;

    [Column("Custom12GUID")]
    public Guid Custom12Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom12Description { get; set; }

    [InverseProperty("Custom12CodeNavigation")]
    public virtual ICollection<TPersonCustomHist> TPersonCustomHists { get; set; } = new List<TPersonCustomHist>();
}
