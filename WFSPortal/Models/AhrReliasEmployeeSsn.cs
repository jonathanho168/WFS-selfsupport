using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("AHR_RELIAS_EmployeeSSN")]
public partial class AhrReliasEmployeeSsn
{
    [Column("Employee ID")]
    [StringLength(255)]
    public string? EmployeeId { get; set; }

    [Column("Full Name")]
    [StringLength(255)]
    public string? FullName { get; set; }

    [Column("NationalID")]
    [StringLength(255)]
    public string? NationalId { get; set; }

    [StringLength(255)]
    public string? F4 { get; set; }
}
