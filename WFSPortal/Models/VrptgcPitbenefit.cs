using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptgcPitbenefit
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("PIT Date", TypeName = "datetime")]
    public DateTime? PitDate { get; set; }

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    public string? BenefitPlanDescription { get; set; }

    [StringLength(15)]
    public string BenefitPlanOptionCode { get; set; } = null!;

    public string? BenefitPlanOptionDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitEndDate { get; set; }

    [Column("COBRAFlag")]
    public bool Cobraflag { get; set; }

    public bool ConsideredTobaccoUserFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? CoverageAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeeContributionAmount { get; set; }

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployerContributionAmount { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    public byte? FixedAge { get; set; }

    [Column(TypeName = "money")]
    public decimal? FlexCreditAmount { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? ImputedAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitContributionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitContributionEndDate { get; set; }

    [Column("PersonID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column(TypeName = "money")]
    public decimal? PremiumAmount { get; set; }

    public string? PrimaryPhysician { get; set; }

    [StringLength(125)]
    public string? ResponsiblePerson { get; set; }

    [Column("ResponsiblePersonGUID")]
    public Guid ResponsiblePersonGuid { get; set; }

    [StringLength(15)]
    public string StartBenefitStatusCode { get; set; } = null!;

    public string? StartBenefitStatus { get; set; }
}
