using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCustom11")]
[Index("Custom11Guid", Name = "RG_tCustom11", IsUnique = true)]
public partial class TCustom11
{
    [Key]
    [StringLength(15)]
    public string Custom11Code { get; set; } = null!;

    [Column("Custom11GUID")]
    public Guid Custom11Guid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? Custom11Description { get; set; }

    [InverseProperty("Custom11CodeNavigation")]
    public virtual ICollection<TPersonCustomHist> TPersonCustomHists { get; set; } = new List<TPersonCustomHist>();
}
