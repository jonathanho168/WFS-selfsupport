using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tBasePayReason")]
[Index("BasePayReasonGuid", Name = "RG_tBasePayReason", IsUnique = true)]
public partial class TBasePayReason
{
    [Key]
    [StringLength(15)]
    public string BasePayReasonCode { get; set; } = null!;

    [Column("BasePayReasonGUID")]
    public Guid BasePayReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? BasePayReasonDescription { get; set; }

    public bool ShowInSalaryPlanningFlag { get; set; }

    [InverseProperty("BasePayReasonCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHists { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("PersonBasePayReasonCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayDetail> UsysSalaryPlanBasePayDetails { get; set; } = new List<UsysSalaryPlanBasePayDetail>();

    [InverseProperty("PersonBasePayReasonCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetails { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();
}
