using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAudit")]
[Index("AuditGuid", Name = "RG_USysAudit", IsUnique = true)]
public partial class UsysAudit
{
    [Column("AuditGUID")]
    public Guid AuditGuid { get; set; }

    public int RowVersion { get; set; }

    [Key]
    [StringLength(128)]
    public string ClassName { get; set; } = null!;
}
