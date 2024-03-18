using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingExpense")]
public partial class TRecruitingExpense
{
    [Key]
    [Column("RecruitingExpenseGUID")]
    public Guid RecruitingExpenseGuid { get; set; }

    [StringLength(15)]
    public string? RequisitionCode { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid? PersonApplicationGuid { get; set; }

    [StringLength(15)]
    public string RecruitingExpenseCategoryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpenseDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal ExpenseAmount { get; set; }

    [StringLength(15)]
    public string ExpenseAmountCurrencyCode { get; set; } = null!;

    [Column("ApprovedByPersonGUID")]
    public Guid? ApprovedByPersonGuid { get; set; }

    public bool PayableToReferralSourceFlag { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ApprovedByPersonGuid")]
    [InverseProperty("TRecruitingExpenses")]
    public virtual TPerson? ApprovedByPerson { get; set; }

    [ForeignKey("ExpenseAmountCurrencyCode")]
    [InverseProperty("TRecruitingExpenses")]
    public virtual TCurrency ExpenseAmountCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonApplicationGuid")]
    [InverseProperty("TRecruitingExpenses")]
    public virtual TPersonApplication? PersonApplication { get; set; }

    [ForeignKey("RecruitingExpenseCategoryCode")]
    [InverseProperty("TRecruitingExpenses")]
    public virtual TRecruitingExpenseCategory RecruitingExpenseCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("RequisitionCode")]
    [InverseProperty("TRecruitingExpenses")]
    public virtual TRequisition? RequisitionCodeNavigation { get; set; }

    [InverseProperty("RecruitingExpense")]
    public virtual ICollection<TRecruitingExpenseAllocation> TRecruitingExpenseAllocations { get; set; } = new List<TRecruitingExpenseAllocation>();
}
