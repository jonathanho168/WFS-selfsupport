using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysArchiveTable")]
public partial class UsysArchiveTable
{
    [Column("USysArchiveTableGUID")]
    public Guid UsysArchiveTableGuid { get; set; }

    [Key]
    [StringLength(128)]
    public string TableName { get; set; } = null!;

    [StringLength(50)]
    public string TableGroupCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LastArchiveDate { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }
}
