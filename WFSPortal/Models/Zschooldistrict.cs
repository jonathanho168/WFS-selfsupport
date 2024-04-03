using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("zschooldistrict")]
public partial class Zschooldistrict
{
    [Key]
    [Column("sdid")]
    public int Sdid { get; set; }

    [Column("zschooldistrict")]
    [StringLength(100)]
    public string? Zschooldistrict1 { get; set; }

    [Column("inactive")]
    public bool? Inactive { get; set; }
}
