using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("AHR-Job_TG")]
public partial class AhrJobTg
{
    [Column("Job Code")]
    [StringLength(255)]
    public string? JobCode { get; set; }

    [Column("Job Title")]
    [StringLength(255)]
    public string? JobTitle { get; set; }

    [Column("Time Group")]
    [StringLength(255)]
    public string? TimeGroup { get; set; }
}
