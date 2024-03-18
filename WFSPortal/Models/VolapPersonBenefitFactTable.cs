using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonBenefitFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitStartDate { get; set; }

    public int? PlanYear { get; set; }

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitPlanOptionCode { get; set; } = null!;

    public string? BenefitPlanOptionDescription { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    [StringLength(15)]
    public string BenefitGroupCode { get; set; } = null!;

    public bool? ActiveEnrollment { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "money")]
    public decimal EmployeeContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal EmployerContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal PremiumAmount { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }

    public string? BenefitDescription { get; set; }

    public Guid PersonBenefitHistGuid { get; set; }
}
