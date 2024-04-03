using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkRollupPlanAmount
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string RollupCode { get; set; } = null!;

    [Column("ExportID")]
    [StringLength(15)]
    public string ExportId { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? EmployeeContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployerContributionAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ImputedAmount { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue1 { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? NumericValue2 { get; set; }

    [StringLength(15)]
    public string EmployeeContributionFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string EmployerContributionFrequencyCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitPlanCode { get; set; } = null!;

    [StringLength(15)]
    public string BenefitPlanOptionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PersonBenefitContributionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBenefitContributionEndDate { get; set; }

    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }
}
