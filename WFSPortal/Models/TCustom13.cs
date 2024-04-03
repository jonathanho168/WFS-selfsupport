using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom13")]
[Index("Custom13Guid", Name = "RG_tCustom13", IsUnique = true)]
public partial class TCustom13
{
    [Key]
    [StringLength(15)]
    public string Custom13Code { get; set; } = null!;

    [Column("Custom13GUID")]
    public Guid Custom13Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom13Description { get; set; }

    [InverseProperty("Custom13CodeNavigation")]
    public virtual ICollection<TPersonCustomHist> TPersonCustomHists { get; set; } = new List<TPersonCustomHist>();
}
