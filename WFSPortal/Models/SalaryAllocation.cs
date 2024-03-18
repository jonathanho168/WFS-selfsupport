using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class SalaryAllocation
{
    [Column("EEID Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EeidNumber { get; set; }

    [Column("Allocated Dept Code")]
    [StringLength(50)]
    public string? AllocatedDeptCode { get; set; }

    [Column("Allocated Percent", TypeName = "money")]
    public decimal? AllocatedPercent { get; set; }

    [Column("Position Code")]
    [StringLength(50)]
    public string? PositionCode { get; set; }

    public Guid? Personguid { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PersonProjectStartDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FullName { get; set; }
}
