using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTrainingExpense")]
[Index("PersonTrainingExpenseCurrencyCode", Name = "IX_tPersonTrainingExpense_PersonTrainingExpenseCurrencyCode")]
public partial class TPersonTrainingExpense
{
    [Key]
    [Column("PersonTrainingExpenseGUID")]
    public Guid PersonTrainingExpenseGuid { get; set; }

    [Column("PersonTrainingGUID")]
    public Guid PersonTrainingGuid { get; set; }

    [StringLength(15)]
    public string PersonTrainingExpenseCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal ExpenseAmount { get; set; }

    [StringLength(80)]
    public string? ExpenseDescription { get; set; }

    [StringLength(15)]
    public string ExpenseTypeCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TPersonTrainingExpenses")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("ExpenseTypeCode")]
    [InverseProperty("TPersonTrainingExpenses")]
    public virtual TExpenseType ExpenseTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonTrainingGuid")]
    [InverseProperty("TPersonTrainingExpenses")]
    public virtual TPersonTraining PersonTraining { get; set; } = null!;

    [ForeignKey("PersonTrainingExpenseCurrencyCode")]
    [InverseProperty("TPersonTrainingExpenses")]
    public virtual TCurrency PersonTrainingExpenseCurrencyCodeNavigation { get; set; } = null!;
}
