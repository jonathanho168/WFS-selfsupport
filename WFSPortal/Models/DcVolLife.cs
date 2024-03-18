using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcVolLife")]
public partial class DcVolLife
{
    [Column("Last Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("First Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("EEBenefitPlan")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EebenefitPlan { get; set; }

    [Column("EEOption")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Eeoption { get; set; }

    [Column("SPBenefitPlan")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SpbenefitPlan { get; set; }

    [Column("SPOption")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Spoption { get; set; }

    [Column("CHBenefitPlan")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ChbenefitPlan { get; set; }

    [Column("CHOption")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Choption { get; set; }
}
