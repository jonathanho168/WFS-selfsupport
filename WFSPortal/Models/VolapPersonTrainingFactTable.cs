using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonTrainingFactTable
{
    [Column("PersonTrainingGUID")]
    public Guid PersonTrainingGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingCompletionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AcquiredDate { get; set; }

    public int? AcquiredYear { get; set; }

    public int? AcquiredQuarter { get; set; }

    public int? AcquiredMonth { get; set; }

    [StringLength(15)]
    public string HowAcquiredCode { get; set; } = null!;

    [StringLength(10)]
    public string? CourseGrade { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EarnedCredits { get; set; }

    [StringLength(15)]
    public string CostDepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string TuitionDepartmentCode { get; set; } = null!;

    public Guid? ClassGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public int? ExpirationQuarter { get; set; }

    public int? ExpirationMonth { get; set; }

    [Column(TypeName = "money")]
    public decimal CourseCost { get; set; }

    [Column(TypeName = "money")]
    public decimal TuitionReimbursementAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal ExpenseAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal CourseCancelCost { get; set; }

    [Column(TypeName = "money")]
    public decimal CourseDropCost { get; set; }

    [Column(TypeName = "money")]
    public decimal CourseDepositCost { get; set; }

    public int CourseCancelPeriod { get; set; }

    public int CourseDropPeriod { get; set; }

    [Column(TypeName = "money")]
    public decimal ClassCost { get; set; }

    public int? ClassEnrollmentCount { get; set; }

    [Column(TypeName = "money")]
    public decimal ClassCancelCost { get; set; }

    [Column(TypeName = "money")]
    public decimal ClassDropCost { get; set; }

    [Column(TypeName = "money")]
    public decimal ClassDepositCost { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
