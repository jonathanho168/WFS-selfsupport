using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tDirectDepositAccountType")]
[Index("DirectDepositAccountTypeGuid", Name = "RG_tDirectDepositAccountType", IsUnique = true)]
public partial class TDirectDepositAccountType
{
    [Key]
    [StringLength(15)]
    public string DirectDepositAccountTypeCode { get; set; } = null!;

    [Column("DirectDepositAccountTypeGUID")]
    public Guid DirectDepositAccountTypeGuid { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public string? DirectDepositAccountTypeDescription { get; set; }

    [InverseProperty("DirectDepositAccountTypeCodeNavigation")]
    public virtual ICollection<TPersonDirectDeposit> TPersonDirectDeposits { get; set; } = new List<TPersonDirectDeposit>();
}
