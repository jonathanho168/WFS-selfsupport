using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRegion")]
[Index("RegionGuid", Name = "RG_tRegion", IsUnique = true)]
public partial class TRegion
{
    [Key]
    [StringLength(15)]
    public string RegionCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("RegionGUID")]
    public Guid RegionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? RegionDescription { get; set; }

    [InverseProperty("RegionCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("RegionCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("RegionCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHists { get; set; } = new List<TPositionHist>();
}
