using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tExportTriggerAction")]
[Index("ExportTriggerActionGuid", Name = "RG_tExportTriggerAction", IsUnique = true)]
public partial class TExportTriggerAction
{
    [Column("ExportTriggerActionGUID")]
    public Guid ExportTriggerActionGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string ExportTriggerActionCode { get; set; } = null!;

    public string? ExportTriggerActionDescription { get; set; }

    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("ExportTriggerActionCodeNavigation")]
    public virtual ICollection<UsysLnkExportTriggerLog> UsysLnkExportTriggerLogs { get; set; } = new List<UsysLnkExportTriggerLog>();
}
