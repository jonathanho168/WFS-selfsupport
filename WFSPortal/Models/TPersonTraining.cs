using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTraining")]
[Index("CourseCode", Name = "IX_tPersonTraining_CourseCode")]
[Index("HowAcquiredCode", Name = "IX_tPersonTraining_HowAcquiredCode")]
[Index("PersonTrainingCurrencyCode", Name = "IX_tPersonTraining_PersonTrainingCurrencyCode")]
[Index("TrainingCompletionCode", Name = "IX_tPersonTraining_TrainingCompletionCode")]
public partial class TPersonTraining
{
    [Key]
    [Column("PersonTrainingGUID")]
    public Guid PersonTrainingGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingCompletionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AcquiredDate { get; set; }

    [StringLength(15)]
    public string HowAcquiredCode { get; set; } = null!;

    [StringLength(10)]
    public string? CourseGrade { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EarnedCredits { get; set; }

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RecertificationDate { get; set; }

    [StringLength(15)]
    public string PersonTrainingCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CourseCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? TuitionReimburseAmount { get; set; }

    public bool? ChargeBackFlag { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string AttendanceCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnrollmentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelOrDropDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CancelOrDropCost { get; set; }

    public bool AutoEnrolledFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    public Guid? ClassGuid { get; set; }

    [StringLength(15)]
    public string CostDepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string TuitionDepartmentCode { get; set; } = null!;

    public byte[]? CompletionCertificate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TrainingStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TrainingEndTime { get; set; }

    [Column("ABACourse")]
    public bool? Abacourse { get; set; }

    [ForeignKey("AttendanceCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual TAttendance AttendanceCodeNavigation { get; set; } = null!;

    [ForeignKey("ClassGuid")]
    [InverseProperty("TPersonTrainings")]
    public virtual TClass? Class { get; set; }

    [ForeignKey("CompanyCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual TCompany CompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CostDepartmentCode")]
    [InverseProperty("TPersonTrainingCostDepartmentCodeNavigations")]
    public virtual TDepartment CostDepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("HowAcquiredCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual THowAcquired HowAcquiredCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTrainings")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonTrainings")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("PersonTrainingCurrencyCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual TCurrency PersonTrainingCurrencyCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonTraining")]
    public virtual ICollection<TPersonTrainingExpense> TPersonTrainingExpenses { get; set; } = new List<TPersonTrainingExpense>();

    [ForeignKey("TrainingCompletionCode")]
    [InverseProperty("TPersonTrainings")]
    public virtual TTrainingCompletion TrainingCompletionCodeNavigation { get; set; } = null!;

    [ForeignKey("TuitionDepartmentCode")]
    [InverseProperty("TPersonTrainingTuitionDepartmentCodeNavigations")]
    public virtual TDepartment TuitionDepartmentCodeNavigation { get; set; } = null!;
}
