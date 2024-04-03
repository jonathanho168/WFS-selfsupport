using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonBenefitCOBRAPayment")]
public partial class TPersonBenefitCobrapayment
{
    [Key]
    [Column("PersonBenefitCOBRAPaymentGUID")]
    public Guid PersonBenefitCobrapaymentGuid { get; set; }

    [Column("PersonBenefitGUID")]
    public Guid PersonBenefitGuid { get; set; }

    [StringLength(15)]
    public string PaymentCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PaymentAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentPeriodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentPeriodEndDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PaymentCurrencyCode")]
    [InverseProperty("TPersonBenefitCobrapayments")]
    public virtual TCurrency PaymentCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonBenefitGuid")]
    [InverseProperty("TPersonBenefitCobrapayments")]
    public virtual TPersonBenefitHist PersonBenefit { get; set; } = null!;
}
