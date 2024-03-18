using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysIdAutoPopulation")]
public partial class UsysIdAutoPopulation
{
    [Key]
    [Column("IdAutoPopulationGUID")]
    public Guid IdAutoPopulationGuid { get; set; }

    [Column("DriverIDField")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DriverIdfield { get; set; }

    [Column("TargetIDField")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TargetIdfield { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }
}
