using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcClearances")]
public partial class DcClearance
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

    [Column("Child Abuse Clearance Issued", TypeName = "datetime")]
    public DateTime? ChildAbuseClearanceIssued { get; set; }

    [Column("PA State Clearance Issued", TypeName = "datetime")]
    public DateTime? PaStateClearanceIssued { get; set; }

    [Column("FBI Clearance Issued", TypeName = "datetime")]
    public DateTime? FbiClearanceIssued { get; set; }

    [Column("FBI Clearance Type (DPW or PDE)")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FbiClearanceTypeDpwOrPde { get; set; }

    [Column("Column 7")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Column7 { get; set; }

    [Column("Column 8")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Column8 { get; set; }

    [Column("Column 9")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Column9 { get; set; }
}
