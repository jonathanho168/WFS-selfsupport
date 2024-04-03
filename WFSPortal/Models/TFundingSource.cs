using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tFundingSource")]
[Index("FundingSourceGuid", Name = "RG_tFundingSource", IsUnique = true)]
public partial class TFundingSource
{
    [Key]
    [StringLength(15)]
    public string FundingSourceCode { get; set; } = null!;

    [Column("FundingSourceGUID")]
    public Guid FundingSourceGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? FundingSourceDescription { get; set; }

    [InverseProperty("FundingSourceCodeNavigation")]
    public virtual ICollection<TPositionFundingHist> TPositionFundingHists { get; set; } = new List<TPositionFundingHist>();
}
