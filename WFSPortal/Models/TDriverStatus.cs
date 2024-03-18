using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDriverStatus")]
[Index("DriverStatusGuid", Name = "RG_tDriverStatus", IsUnique = true)]
public partial class TDriverStatus
{
    [Key]
    [StringLength(15)]
    public string DriverStatusCode { get; set; } = null!;

    [Column("DriverStatusGUID")]
    public Guid DriverStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? DriverStatusDescription { get; set; }

    [InverseProperty("DriverStatusNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();
}
