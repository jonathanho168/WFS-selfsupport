using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkRollupBenefit")]
[Index("LnkRollupBenefitGuid", Name = "RG_USysLnkRollupBenefit", IsUnique = true)]
public partial class UsysLnkRollupBenefit
{
    public Guid BenefitPlanOptionGuid { get; set; }

    [Key]
    [Column("LnkRollupBenefitGUID")]
    public Guid LnkRollupBenefitGuid { get; set; }

    public Guid LnkRollupCodeGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("BenefitPlanOptionGuid")]
    [InverseProperty("UsysLnkRollupBenefits")]
    public virtual TBenefitPlanOption BenefitPlanOption { get; set; } = null!;

    [ForeignKey("LnkRollupCodeGuid")]
    [InverseProperty("UsysLnkRollupBenefits")]
    public virtual UsysLnkRollupCode LnkRollupCode { get; set; } = null!;
}
