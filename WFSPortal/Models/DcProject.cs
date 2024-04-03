using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcProject")]
public partial class DcProject
{
    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectBudgetCurrencyCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }
}
