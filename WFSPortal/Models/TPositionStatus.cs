using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPositionStatus")]
[Index("PositionStatusGuid", Name = "RG_tPositionStatus", IsUnique = true)]
public partial class TPositionStatus
{
    [Key]
    [StringLength(15)]
    public string PositionStatusCode { get; set; } = null!;

    [Column("PositionStatusGUID")]
    public Guid PositionStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool ActiveFlag { get; set; }

    public string? PositionStatusDescription { get; set; }

    [InverseProperty("CurrentPositionStatusCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHistCurrentPositionStatusCodeNavigations { get; set; } = new List<TPositionHist>();

    [InverseProperty("PitpositionStatusCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHistPitpositionStatusCodeNavigations { get; set; } = new List<TPositionHist>();
}
