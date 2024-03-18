using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkExportStatusCode")]
[Index("LnkExportStatusGuid", Name = "RG_USysLnkExportStatusCode", IsUnique = true)]
public partial class UsysLnkExportStatusCode
{
    [Key]
    [StringLength(15)]
    public string ExportStatusCode { get; set; } = null!;

    [Column("LnkExportStatusGUID")]
    public Guid LnkExportStatusGuid { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public string? ExportStatusDescription { get; set; }

    [InverseProperty("ExportStatusCodeNavigation")]
    public virtual ICollection<UsysLnkExportLog> UsysLnkExportLogs { get; set; } = new List<UsysLnkExportLog>();
}
