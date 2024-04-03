using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysBenefitEnrollmentContributionFailed")]
public partial class UsysBenefitEnrollmentContributionFailed
{
    [StringLength(128)]
    public string UserName { get; set; } = null!;

    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BenefitContributionStartDate { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

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

    [StringLength(4000)]
    [Unicode(false)]
    public string? FailedMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [Key]
    [Column("BenefitEnrollmentContributionFailedGUID")]
    public Guid BenefitEnrollmentContributionFailedGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("BenefitPlanOptionGUID")]
    public Guid BenefitPlanOptionGuid { get; set; }
}
