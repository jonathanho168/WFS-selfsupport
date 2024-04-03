using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonBenefit")]
public partial class DcPersonBenefit
{
    [Column("SSN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ssn { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitPlanCode { get; set; }

    [Column("Benefit Option Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BenefitOptionCode { get; set; }

    [Column("Start Date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("Retirement Plan Pct", TypeName = "money")]
    public decimal? RetirementPlanPct { get; set; }

    [Column("Spending Act Amount", TypeName = "money")]
    public decimal? SpendingActAmount { get; set; }

    [Column("Employee Elected Coverage", TypeName = "money")]
    public decimal? EmployeeElectedCoverage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Smoker { get; set; }
}
