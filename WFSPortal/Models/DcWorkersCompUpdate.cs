using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcWorkersCompUpdate")]
public partial class DcWorkersCompUpdate
{
    [Column("Position Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }

    [Column("Job Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }

    [Column("Job Title")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? JobTitle { get; set; }

    [Column("Workers Comp Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WorkersCompCode { get; set; }

    [Column("Workers Comp Description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? WorkersCompDescription { get; set; }
}
