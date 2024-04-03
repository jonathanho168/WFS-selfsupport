using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPositionJobTitle")]
public partial class DcPositionJobTitle
{
    [StringLength(500)]
    [Unicode(false)]
    public string? PositionTitle { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JobTitle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PositionCode { get; set; }
}
