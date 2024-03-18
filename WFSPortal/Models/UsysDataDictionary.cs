using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysDataDictionary")]
public partial class UsysDataDictionary
{
    [Key]
    [Column("DataDictionaryGUID")]
    public Guid DataDictionaryGuid { get; set; }

    [StringLength(128)]
    public string ObjectName { get; set; } = null!;

    [StringLength(128)]
    public string? DatabaseColumnName { get; set; }

    [StringLength(250)]
    public string? TaskElementKey { get; set; }

    public string? ObjectDescription { get; set; }

    public bool ShowHelpIconFlag { get; set; }

    public int RowVersion { get; set; }
}
