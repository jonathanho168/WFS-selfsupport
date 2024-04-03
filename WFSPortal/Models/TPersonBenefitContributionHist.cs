using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitContributionHist")]
public partial class TPersonBenefitContributionHist
{
    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitContributionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitContributionEndDate { get; set; }

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

    public bool PersonBenefitContributionCurrentFlag { get; set; }

    [Key]
    [Column("PersonBenefitContributionGUID")]
    public Guid PersonBenefitContributionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePreTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePostTaxAmount { get; set; }

    [ForeignKey("PersonBenefitGuid")]
    [InverseProperty("TPersonBenefitContributionHists")]
    public virtual TPersonBenefitHist PersonBenefit { get; set; } = null!;
}
