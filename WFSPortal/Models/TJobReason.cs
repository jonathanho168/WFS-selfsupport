using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobReason")]
[Index("JobReasonGuid", Name = "RG_tJobReason", IsUnique = true)]
public partial class TJobReason
{
    [Key]
    [StringLength(15)]
    public string JobReasonCode { get; set; } = null!;

    [Column("JobReasonGUID")]
    public Guid JobReasonGuid { get; set; }

    public bool PromotionFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? JobReasonDescription { get; set; }

    [InverseProperty("JobReasonCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();
}
