using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBenefitRangeValue")]
[Index("BenefitRangeGuid", "LowerLimit", Name = "AK_tBenefitRangeValue_RangeGUID_LowerLimit", IsUnique = true)]
public partial class TBenefitRangeValue
{
    [Column("BenefitRangeGUID")]
    public Guid BenefitRangeGuid { get; set; }

    public int LowerLimit { get; set; }

    public int UpperLimit { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Multiplier1 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Multiplier2 { get; set; }

    [Key]
    [Column("BenefitRangeValueGUID")]
    public Guid BenefitRangeValueGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Multiplier3 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Multiplier4 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Multiplier5 { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Multiplier6 { get; set; }

    [ForeignKey("BenefitRangeGuid")]
    [InverseProperty("TBenefitRangeValues")]
    public virtual TBenefitRangeHist BenefitRange { get; set; } = null!;
}
