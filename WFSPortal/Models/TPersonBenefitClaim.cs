using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitClaim")]
public partial class TPersonBenefitClaim
{
    [Key]
    [Column("PersonBenefitClaimGUID")]
    public Guid PersonBenefitClaimGuid { get; set; }

    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ClaimDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? ClaimAmount { get; set; }

    public string? ClaimDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaidDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? PaidAmount { get; set; }

    [StringLength(15)]
    public string PersonBenefitClaimCurrencyCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("PersonBenefitGuid")]
    [InverseProperty("TPersonBenefitClaims")]
    public virtual TPersonBenefitHist PersonBenefit { get; set; } = null!;

    [ForeignKey("PersonBenefitClaimCurrencyCode")]
    [InverseProperty("TPersonBenefitClaims")]
    public virtual TCurrency PersonBenefitClaimCurrencyCodeNavigation { get; set; } = null!;
}
