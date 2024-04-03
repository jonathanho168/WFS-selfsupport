using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonTrainingExpenseFactTable
{
    [Column("PersonTrainingExpenseGUID")]
    public Guid PersonTrainingExpenseGuid { get; set; }

    [Column("PersonTrainingGUID")]
    public Guid PersonTrainingGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(80)]
    public string? ExpenseDescription { get; set; }

    [StringLength(15)]
    public string ExpenseDepartmentUnit { get; set; } = null!;

    [StringLength(15)]
    public string ExpenseTypeCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal ExpenseAmount { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }
}
