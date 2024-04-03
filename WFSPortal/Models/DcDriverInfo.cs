using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcDriverInfo")]
public partial class DcDriverInfo
{
    [Column("Employee Name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EmployeeName { get; set; }

    [Column("State & License Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StateLicenseNumber { get; set; }

    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("Expiration Date", TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [Column("Expiration Month")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExpirationMonth { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
