using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VNonZeroBenefitContributionHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

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

    [Column("PersonBenefitContributionGUID")]
    public Guid PersonBenefitContributionGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }
}
