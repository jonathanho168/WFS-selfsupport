using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tStatus")]
[Index("StatusGuid", Name = "RG_tStatus", IsUnique = true)]
public partial class TStatus
{
    [Key]
    [StringLength(15)]
    public string StatusCode { get; set; } = null!;

    [StringLength(15)]
    public string StatusGroupCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public bool TerminationFlag { get; set; }

    [Column("StatusGUID")]
    public Guid StatusGuid { get; set; }

    public int RowVersion { get; set; }

    public bool ActiveFlag { get; set; }

    public bool AllowAccessToSystem { get; set; }

    public bool AllowAccessToCss { get; set; }

    public string? StatusDescription { get; set; }

    [ForeignKey("StatusGroupCode")]
    [InverseProperty("TStatuses")]
    public virtual TStatusGroup StatusGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("StatusCodeNavigation")]
    public virtual ICollection<TPersonStatusHist> TPersonStatusHists { get; set; } = new List<TPersonStatusHist>();
}
