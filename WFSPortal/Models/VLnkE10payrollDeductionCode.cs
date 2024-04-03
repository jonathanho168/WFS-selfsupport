using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkE10payrollDeductionCode
{
    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [StringLength(15)]
    public string DeductionId { get; set; } = null!;

    public string? DeductionDescription { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string ElecDeposit { get; set; } = null!;

    [StringLength(15)]
    public string? Type { get; set; }
}
