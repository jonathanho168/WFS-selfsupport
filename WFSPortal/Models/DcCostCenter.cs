using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcCostCenter")]
public partial class DcCostCenter
{
    [StringLength(50)]
    [Unicode(false)]
    public string? CostCenterCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CostCenterDescription { get; set; }
}
