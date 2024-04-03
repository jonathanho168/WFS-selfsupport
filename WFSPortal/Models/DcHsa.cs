using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcHSA")]
public partial class DcHsa
{
    [Column("ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("Tax ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxId { get; set; }

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

    [Column("dedpercent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dedpercent { get; set; }

    [Column(TypeName = "money")]
    public decimal? Dedamount { get; set; }
}
