using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkDirectDeposit
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("ABARoutingNumber")]
    [StringLength(40)]
    public string? AbaroutingNumber { get; set; }

    [StringLength(50)]
    public string AccountNumber { get; set; } = null!;

    [StringLength(15)]
    public string DirectDepositAccountTypeCode { get; set; } = null!;

    [StringLength(80)]
    public string InstitutionName { get; set; } = null!;

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? DeductionAmount { get; set; }

    public bool PrimaryDepositFlag { get; set; }

    [Column("SignedByPersonGUID")]
    public Guid? SignedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDate { get; set; }

    [Column("PersonDirectDepositGUID")]
    public Guid PersonDirectDepositGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? DeductionPercent { get; set; }

    [StringLength(15)]
    public string InstitutionCountryCode { get; set; } = null!;

    [Column("CsfAnzBSBNumber")]
    [StringLength(50)]
    public string? CsfAnzBsbnumber { get; set; }

    [StringLength(80)]
    public string? AccountName { get; set; }

    public int? BankDepositPositionNumber { get; set; }
}
