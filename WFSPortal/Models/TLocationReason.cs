using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLocationReason")]
[Index("LocationReasonGuid", Name = "RG_tLocationReason", IsUnique = true)]
public partial class TLocationReason
{
    [Key]
    [StringLength(15)]
    public string LocationReasonCode { get; set; } = null!;

    [Column("LocationReasonGUID")]
    public Guid LocationReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? LocationReasonDescription { get; set; }

    [InverseProperty("LocationReasonCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();
}
