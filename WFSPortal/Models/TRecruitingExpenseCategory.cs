using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingExpenseCategory")]
[Index("RecruitingExpenseCategoryGuid", Name = "RG_tRecruitingExpenseCategory", IsUnique = true)]
public partial class TRecruitingExpenseCategory
{
    [Key]
    [StringLength(15)]
    public string RecruitingExpenseCategoryCode { get; set; } = null!;

    [Column("RecruitingExpenseCategoryGUID")]
    public Guid RecruitingExpenseCategoryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? RecruitingExpenseCategoryDescription { get; set; }

    [InverseProperty("RecruitingExpenseCategoryCodeNavigation")]
    public virtual ICollection<TRecruitingExpense> TRecruitingExpenses { get; set; } = new List<TRecruitingExpense>();
}
