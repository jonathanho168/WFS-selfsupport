using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom14")]
[Index("Custom14Guid", Name = "RG_tCustom14", IsUnique = true)]
public partial class TCustom14
{
    [Key]
    [StringLength(15)]
    public string Custom14Code { get; set; } = null!;

    [Column("Custom14GUID")]
    public Guid Custom14Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom14Description { get; set; }

    [InverseProperty("Custom14CodeNavigation")]
    public virtual ICollection<TPersonCustomHist> TPersonCustomHists { get; set; } = new List<TPersonCustomHist>();
}
