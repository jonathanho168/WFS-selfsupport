using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOtherPayReason")]
[Index("OtherPayReasonGuid", Name = "RG_tOtherPayReason", IsUnique = true)]
public partial class TOtherPayReason
{
    [Key]
    [StringLength(15)]
    public string OtherPayReasonCode { get; set; } = null!;

    [Column("OtherPayReasonGUID")]
    public Guid OtherPayReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OtherPayReasonDescription { get; set; }

    [InverseProperty("OtherPayReasonCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHists { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PersonOtherPayReasonCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayDetail> UsysSalaryPlanOtherPayDetails { get; set; } = new List<UsysSalaryPlanOtherPayDetail>();

    [InverseProperty("PersonOtherPayReasonCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetails { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();
}
