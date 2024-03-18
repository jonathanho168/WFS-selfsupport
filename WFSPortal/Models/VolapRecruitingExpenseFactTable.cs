using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapRecruitingExpenseFactTable
{
    [Column("RecruitingExpenseGUID")]
    public Guid RecruitingExpenseGuid { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string RequisitionFlag { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ApplicationFlag { get; set; } = null!;

    [StringLength(15)]
    public string? RequisitionCode { get; set; }

    [Column("PersonApplicationGUID")]
    public Guid? PersonApplicationGuid { get; set; }

    [Column("ApplicationID")]
    public int? ApplicationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpenseDate { get; set; }

    public int? ExpenseYear { get; set; }

    public int? ExpenseQuarter { get; set; }

    public int? ExpenseMonth { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal ExpenseAmount { get; set; }
}
