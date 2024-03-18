using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCodeTable")]
[Index("CodeTableGuid", Name = "RG_USysCodeTable", IsUnique = true)]
public partial class UsysCodeTable
{
    [Key]
    [StringLength(128)]
    public string CodeTable { get; set; } = null!;

    [StringLength(128)]
    public string? CodeColumn { get; set; }

    [StringLength(128)]
    public string? DescriptionColumn { get; set; }

    [Column("CodeTableGUID")]
    public Guid CodeTableGuid { get; set; }

    public bool CanBeFilteredFlag { get; set; }

    public bool FilteredFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("TableGUIDColumn")]
    [StringLength(128)]
    public string? TableGuidcolumn { get; set; }
}
