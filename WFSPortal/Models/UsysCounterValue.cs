using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysCounterValue")]
public partial class UsysCounterValue
{
    [StringLength(128)]
    public string ClassName { get; set; } = null!;

    [StringLength(128)]
    public string PropertyName { get; set; } = null!;

    public int Counter { get; set; }

    [Key]
    [Column("CounterValueGUID")]
    public Guid CounterValueGuid { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string? AutoNumberClass { get; set; }

    public bool SetOnSynchronizationFlag { get; set; }
}
