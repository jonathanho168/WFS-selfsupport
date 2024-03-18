using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class DcForeignKey
{
    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [StringLength(128)]
    public string ParentTable { get; set; } = null!;

    [StringLength(128)]
    public string ChildTable { get; set; } = null!;
}
