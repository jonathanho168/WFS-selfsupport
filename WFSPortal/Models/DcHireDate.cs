using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcHireDates")]
public partial class DcHireDate
{
    [Column("Last Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("First Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [Column("Adjusted Hire Date", TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    [Column("Seniority Date", TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }
}
