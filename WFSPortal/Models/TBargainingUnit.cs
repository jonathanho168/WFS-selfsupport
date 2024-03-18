using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBargainingUnit")]
public partial class TBargainingUnit
{
    public Guid BargainingUnitGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string BargainingUnitCode { get; set; } = null!;

    public string? BargainingUnitDescription { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string UnionCode { get; set; } = null!;

    [InverseProperty("BargainingUnitCodeNavigation")]
    public virtual ICollection<TPersonUnionHist> TPersonUnionHists { get; set; } = new List<TPersonUnionHist>();

    [ForeignKey("UnionCode")]
    [InverseProperty("TBargainingUnits")]
    public virtual TUnion UnionCodeNavigation { get; set; } = null!;
}
