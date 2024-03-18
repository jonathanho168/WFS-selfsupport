using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcConfigLinkTables")]
public partial class DcConfigLinkTable
{
    [StringLength(100)]
    [Unicode(false)]
    public string? FunctionalArea { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TableName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SortOrder { get; set; }

    public bool? ConfigureFlag { get; set; }

    public bool? AllowDeleteFlag { get; set; }

    public bool? DeleteOnlyFlag { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LinkParentTable { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LinkParentField { get; set; }
}
