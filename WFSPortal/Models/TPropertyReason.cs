using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPropertyReason")]
[Index("PropertyReasonGuid", Name = "RG_tPropertyReason", IsUnique = true)]
public partial class TPropertyReason
{
    [Key]
    [StringLength(15)]
    public string PropertyReasonCode { get; set; } = null!;

    [Column("PropertyReasonGUID")]
    public Guid PropertyReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PropertyReasonDescription { get; set; }

    [InverseProperty("IssueReasonCodeNavigation")]
    public virtual ICollection<TPersonPropertyCardHist> TPersonPropertyCardHistIssueReasonCodeNavigations { get; set; } = new List<TPersonPropertyCardHist>();

    [InverseProperty("ReturnReasonCodeNavigation")]
    public virtual ICollection<TPersonPropertyCardHist> TPersonPropertyCardHistReturnReasonCodeNavigations { get; set; } = new List<TPersonPropertyCardHist>();

    [InverseProperty("IssueReasonCodeNavigation")]
    public virtual ICollection<TPersonPropertyHist> TPersonPropertyHistIssueReasonCodeNavigations { get; set; } = new List<TPersonPropertyHist>();

    [InverseProperty("ReturnReasonCodeNavigation")]
    public virtual ICollection<TPersonPropertyHist> TPersonPropertyHistReturnReasonCodeNavigations { get; set; } = new List<TPersonPropertyHist>();
}
