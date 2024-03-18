using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tExportTriggerStatus")]
[Index("ExportTriggerStatusGuid", Name = "RG_tExportTriggerStatus", IsUnique = true)]
public partial class TExportTriggerStatus
{
    [Column("ExportTriggerStatusGUID")]
    public Guid ExportTriggerStatusGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string ExportTriggerStatusCode { get; set; } = null!;

    public string? ExportTriggerStatusDescription { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("ExportTriggerStatusCodeNavigation")]
    public virtual ICollection<UsysLnkExportTriggerLog> UsysLnkExportTriggerLogs { get; set; } = new List<UsysLnkExportTriggerLog>();
}
