using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingAgreement")]
public partial class TRecruitingAgreement
{
    [Key]
    [Column("RecruitingAgreementGUID")]
    public Guid RecruitingAgreementGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(15)]
    public string RecruitingFirmCode { get; set; } = null!;

    [StringLength(15)]
    public string RecruitingAgreementTypeCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? PaymentAmount { get; set; }

    [StringLength(15)]
    public string PaymentAmountCurrencyCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PaymentPercent { get; set; }

    [StringLength(80)]
    public string? RefundTerms { get; set; }

    [StringLength(80)]
    public string? ReplacementTerms { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PaymentAmountCurrencyCode")]
    [InverseProperty("TRecruitingAgreements")]
    public virtual TCurrency PaymentAmountCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("RecruitingAgreementTypeCode")]
    [InverseProperty("TRecruitingAgreements")]
    public virtual TRecruitingAgreementType RecruitingAgreementTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("RecruitingFirmCode")]
    [InverseProperty("TRecruitingAgreements")]
    public virtual TRecruitingFirm RecruitingFirmCodeNavigation { get; set; } = null!;
}
