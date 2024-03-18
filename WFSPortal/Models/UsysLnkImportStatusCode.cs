using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportStatusCode")]
public partial class UsysLnkImportStatusCode
{
    [Key]
    [StringLength(15)]
    public string ImportStatusCode { get; set; } = null!;

    public string? ImportStatusDescription { get; set; }

    [Column("LnkImportStatusGUID")]
    public Guid LnkImportStatusGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [InverseProperty("ImportStatusCodeNavigation")]
    public virtual ICollection<UsysLnkImportLog> UsysLnkImportLogs { get; set; } = new List<UsysLnkImportLog>();
}
