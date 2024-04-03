using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcPersonDirectDep")]
public partial class DcPersonDirectDep
{
    [Column("Tax ID (SSN)")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxIdSsn { get; set; }

    [Column("Account Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("Bank Deposit Prenote Date", TypeName = "datetime")]
    public DateTime? BankDepositPrenoteDate { get; set; }

    [Column("Deduction Amount -1", TypeName = "money")]
    public decimal? DeductionAmount1 { get; set; }

    [Column("Deduction Code  Direct Deposit ")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeductionCodeDirectDeposit { get; set; }

    [Column("Deduction Description")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeductionDescription { get; set; }

    [Column("Deduction Percent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeductionPercent { get; set; }

    [Column("Deposit Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DepositNumber { get; set; }

    [Column("Effective Date", TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column("Effective End Date", TypeName = "datetime")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("For Bonus Pay only")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForBonusPayOnly { get; set; }

    [Column("Full Net")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FullNet { get; set; }

    [Column("Percent Net")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PercentNet { get; set; }

    [Column("Prenotification Method Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrenotificationMethodCode { get; set; }

    [Column("Prenotification Method Description")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrenotificationMethodDescription { get; set; }

    [Column("Priority #")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [Column("Routing Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RoutingNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }
}
