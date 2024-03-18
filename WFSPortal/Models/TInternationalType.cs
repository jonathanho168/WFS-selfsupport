using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tInternationalType")]
[Index("InternationalTypeGuid", Name = "RG_tInternationalType", IsUnique = true)]
public partial class TInternationalType
{
    [Key]
    [StringLength(15)]
    public string InternationalTypeCode { get; set; } = null!;

    [Column("InternationalTypeGUID")]
    public Guid InternationalTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? InternationalTypeDescription { get; set; }

    [InverseProperty("InternationalTypeCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();
}
