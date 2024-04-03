using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysNightlyRun")]
[Index("NightlyRunClass", Name = "AK_USysNightlyRun", IsUnique = true)]
public partial class UsysNightlyRun
{
    [Key]
    [Column("NightlyRunGUID")]
    public Guid NightlyRunGuid { get; set; }

    [StringLength(50)]
    public string NightlyRunClass { get; set; } = null!;

    [StringLength(256)]
    public string? ServerName { get; set; }

    public bool IsActive { get; set; }

    public int RowVersion { get; set; }

    [StringLength(50)]
    public string? NightlyRunName { get; set; }

    public string? Description { get; set; }

    public int SequenceOrder { get; set; }
}
