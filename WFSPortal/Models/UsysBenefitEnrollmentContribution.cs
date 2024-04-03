using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentContribution")]
public partial class UsysBenefitEnrollmentContribution
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitContributionStartDate { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    public Guid BenefitPlanOptionGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BenefitContributionEndDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CoverageAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeeContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployerContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? FlexCreditAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ImputedAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? PremiumAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentContributionGUID")]
    public Guid BenefitEnrollmentContributionGuid { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePreTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePostTaxAmount { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysBenefitEnrollmentContributions")]
    public virtual TPerson Person { get; set; } = null!;
}
