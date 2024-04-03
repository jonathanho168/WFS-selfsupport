using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tStatusReason")]
[Index("StatusReasonGuid", Name = "RG_tStatusReason", IsUnique = true)]
public partial class TStatusReason
{
    [Key]
    [StringLength(15)]
    public string StatusReasonCode { get; set; } = null!;

    [Column("StatusReasonGUID")]
    public Guid StatusReasonGuid { get; set; }

    public bool HireFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool RecallFromLayoffFlag { get; set; }

    public string? StatusReasonDescription { get; set; }

    [InverseProperty("StatusReasonCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();
}
