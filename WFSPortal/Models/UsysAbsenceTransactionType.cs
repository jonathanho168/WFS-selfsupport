using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysAbsenceTransactionType")]
[Index("AbsenceTransactionTypeGuid", Name = "RG_tPersonAbsenceOverrideHist", IsUnique = true)]
public partial class UsysAbsenceTransactionType
{
    public Guid AbsenceTransactionTypeGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string AbsenceTransactionTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public int? SortOrderBeginAccrual { get; set; }

    public int? SortOrderEndAccrual { get; set; }

    public string? AbsenceTransactionTypeDescription { get; set; }

    [InverseProperty("AbsenceTransactionTypeCodeNavigation")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();
}
