using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOvertimeStatus")]
[Index("OvertimeStatusGuid", Name = "RG_tOvertimeStatus", IsUnique = true)]
public partial class TOvertimeStatus
{
    [Key]
    [StringLength(15)]
    public string OvertimeStatusCode { get; set; } = null!;

    [Column("OvertimeStatusGUID")]
    public Guid OvertimeStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OvertimeStatusDescription { get; set; }

    [InverseProperty("OvertimeStatusCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();
}
