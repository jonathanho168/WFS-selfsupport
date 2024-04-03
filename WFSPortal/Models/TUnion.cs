using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tUnion")]
[Index("UnionGuid", Name = "RG_tUnion", IsUnique = true)]
public partial class TUnion
{
    [Key]
    [StringLength(15)]
    public string UnionCode { get; set; } = null!;

    [Column("UnionGUID")]
    public Guid UnionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? UnionDescription { get; set; }

    [InverseProperty("UnionCodeNavigation")]
    public virtual ICollection<TBargainingUnit> TBargainingUnits { get; set; } = new List<TBargainingUnit>();

    [InverseProperty("UnionCodeNavigation")]
    public virtual ICollection<TPersonUnionHist> TPersonUnionHists { get; set; } = new List<TPersonUnionHist>();
}
