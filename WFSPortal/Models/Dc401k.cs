using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dc401k")]
public partial class Dc401k
{
    [Column("ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("Tax ID (SSN)")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxIdSsn { get; set; }

    [Column("Termination Date", TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [Column("First Name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("Last Name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("dedcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dedcode { get; set; }

    [Column("Deduction Description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DeductionDescription { get; set; }

    [Column("Effective Date")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EffectiveDate { get; set; }

    [Column("Effective End Date")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EffectiveEndDate { get; set; }

    [Column("dedpercent", TypeName = "money")]
    public decimal? Dedpercent { get; set; }
}
