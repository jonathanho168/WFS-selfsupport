using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDepartureReason")]
[Index("DepartureReasonGuid", Name = "RG_tDepartureReason", IsUnique = true)]
public partial class TDepartureReason
{
    [Key]
    [StringLength(15)]
    public string DepartureReasonCode { get; set; } = null!;

    [Column("DepartureReasonGUID")]
    public Guid DepartureReasonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DepartureReasonDescription { get; set; }

    [InverseProperty("DepartureReasonCodeNavigation")]
    public virtual ICollection<TPersonEmploymentHist> TPersonEmploymentHists { get; set; } = new List<TPersonEmploymentHist>();
}
