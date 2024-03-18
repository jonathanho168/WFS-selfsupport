using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tRecruitingExpenseAllocation")]
public partial class TRecruitingExpenseAllocation
{
    [Key]
    [Column("RecruitingExpenseAllocationGUID")]
    public Guid RecruitingExpenseAllocationGuid { get; set; }

    [Column("RecruitingExpenseGUID")]
    public Guid RecruitingExpenseGuid { get; set; }

    [StringLength(128)]
    public string AllocationCodeTable { get; set; } = null!;

    [StringLength(15)]
    public string AllocationCode { get; set; } = null!;

    [Column("AllocationPersonGUID")]
    public Guid? AllocationPersonGuid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AllocationAmount { get; set; }

    [StringLength(15)]
    public string AllocationAmountCurrencyCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public string? AllocationDescription { get; set; }

    [ForeignKey("AllocationAmountCurrencyCode")]
    [InverseProperty("TRecruitingExpenseAllocations")]
    public virtual TCurrency AllocationAmountCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("AllocationPersonGuid")]
    [InverseProperty("TRecruitingExpenseAllocations")]
    public virtual TPerson? AllocationPerson { get; set; }

    [ForeignKey("RecruitingExpenseGuid")]
    [InverseProperty("TRecruitingExpenseAllocations")]
    public virtual TRecruitingExpense RecruitingExpense { get; set; } = null!;
}
