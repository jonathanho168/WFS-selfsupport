using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("aaDirectDep")]
public partial class AaDirectDep
{
    [Column("File Number")]
    [StringLength(255)]
    public string? FileNumber { get; set; }

    [Column("Last Name First Name")]
    [StringLength(255)]
    public string? LastNameFirstName { get; set; }

    [Column("Bank Account Number")]
    [StringLength(255)]
    public string? BankAccountNumber { get; set; }

    [Column("Bank Full Deposit Indicator")]
    [StringLength(255)]
    public string? BankFullDepositIndicator { get; set; }

    [Column("Deposit Number")]
    [StringLength(255)]
    public string? DepositNumber { get; set; }

    [Column("Transit ABA Number")]
    [StringLength(255)]
    public string? TransitAbaNumber { get; set; }

    [Column("Scheduled Deduction Code")]
    [StringLength(255)]
    public string? ScheduledDeductionCode { get; set; }

    [Column("Scheduled Deduction Amount")]
    public double? ScheduledDeductionAmount { get; set; }
}
