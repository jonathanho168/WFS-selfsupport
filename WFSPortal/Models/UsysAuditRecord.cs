using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAuditRecord")]
[Index("RecordId", Name = "IX_USysAuditRecord_RecordID")]
[Index("Source", "ClassName", "PersonGuid", Name = "WFS_UsysAuditRecord_Source_Class_Person")]
public partial class UsysAuditRecord
{
    [Key]
    [Column("AuditRecordGUID")]
    public Guid AuditRecordGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(1)]
    public string AuditRecordType { get; set; } = null!;

    [StringLength(100)]
    public string Source { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string Changes { get; set; } = null!;

    [StringLength(256)]
    public string? UserName { get; set; }

    [Column("RecordID")]
    public Guid? RecordId { get; set; }

    [StringLength(128)]
    public string? ClassName { get; set; }

    [Column("PersonGUID")]
    public Guid? PersonGuid { get; set; }
}
