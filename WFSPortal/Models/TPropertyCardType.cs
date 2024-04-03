using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPropertyCardType")]
[Index("PropertyCardTypeGuid", Name = "RG_tPropertyCardType", IsUnique = true)]
public partial class TPropertyCardType
{
    [Key]
    [StringLength(15)]
    public string PropertyCardTypeCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("PropertyCardTypeGUID")]
    public Guid PropertyCardTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public string? PropertyCardTypeDescription { get; set; }

    [InverseProperty("PropertyCardTypeCodeNavigation")]
    public virtual ICollection<TPersonPropertyCardHist> TPersonPropertyCardHists { get; set; } = new List<TPersonPropertyCardHist>();
}
