using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tExpenseType")]
[Index("ExpenseTypeGuid", Name = "RG_tExpenseType", IsUnique = true)]
public partial class TExpenseType
{
    [Key]
    [StringLength(15)]
    public string ExpenseTypeCode { get; set; } = null!;

    [Column("ExpenseTypeGUID")]
    public Guid ExpenseTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ExpenseTypeDescription { get; set; }

    [InverseProperty("ExpenseTypeCodeNavigation")]
    public virtual ICollection<TPersonTrainingExpense> TPersonTrainingExpenses { get; set; } = new List<TPersonTrainingExpense>();
}
