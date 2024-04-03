using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOtherPayType")]
[Index("OtherPayTypeGuid", Name = "RG_tOtherPayType", IsUnique = true)]
public partial class TOtherPayType
{
    [Key]
    [StringLength(15)]
    public string OtherPayTypeCode { get; set; } = null!;

    [Column("OtherPayTypeGUID")]
    public Guid OtherPayTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool HiringBonusFlag { get; set; }

    public string? OtherPayTypeDescription { get; set; }

    [InverseProperty("OtherPayTypeCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHists { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PersonOtherPayTypeCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayDetail> UsysSalaryPlanOtherPayDetails { get; set; } = new List<UsysSalaryPlanOtherPayDetail>();

    [InverseProperty("PersonOtherPayTypeCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetails { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();
}
