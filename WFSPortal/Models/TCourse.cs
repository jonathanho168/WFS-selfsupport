using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourse")]
[Index("CourseCompanyCode", Name = "IX_tCourse_CourseCompanyCode")]
[Index("CourseCurrencyCode", Name = "IX_tCourse_CourseCurrencyCode")]
[Index("CourseGuid", Name = "RG_tCourse", IsUnique = true)]
public partial class TCourse
{
    [Key]
    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string CourseCompanyCode { get; set; } = null!;

    public bool InternalCourseFlag { get; set; }

    public bool MealsIncludedFlag { get; set; }

    [StringLength(15)]
    public string CourseCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CourseCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? CourseDropCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? CourseCancelCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? CourseDepositCost { get; set; }

    public string? Comments { get; set; }

    [Column("CourseGUID")]
    public Guid CourseGuid { get; set; }

    public int? RetrainDeadlineMonths { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TotalHours { get; set; }

    public bool InactiveFlag { get; set; }

    [StringLength(15)]
    public string CourseTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingProviderCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CourseCredits { get; set; }

    public int? CancelPeriod { get; set; }

    public int? DropPeriod { get; set; }

    public int RowVersion { get; set; }

    public bool ScheduledFlag { get; set; }

    public byte[]? Attachment { get; set; }

    public bool TrainingProgramOnlyFlag { get; set; }

    public bool AllowSelfCompletionFlag { get; set; }

    public int? CreateRetrainingJobNeedsMonths { get; set; }

    public string? CourseDetail { get; set; }

    public string? CourseTitle { get; set; }

    public bool Act48 { get; set; }

    [Column("ABA")]
    public bool? Aba { get; set; }

    [ForeignKey("CourseCompanyCode")]
    [InverseProperty("TCourses")]
    public virtual TCompany CourseCompanyCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCurrencyCode")]
    [InverseProperty("TCourses")]
    public virtual TCurrency CourseCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseTypeCode")]
    [InverseProperty("TCourses")]
    public virtual TCourseType CourseTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TClass> TClasses { get; set; } = new List<TClass>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseCertification> TCourseCertifications { get; set; } = new List<TCourseCertification>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseCompetency> TCourseCompetencies { get; set; } = new List<TCourseCompetency>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseCourse> TCourseCourseCourseCodeNavigations { get; set; } = new List<TCourseCourse>();

    [InverseProperty("ParentCourseCodeNavigation")]
    public virtual ICollection<TCourseCourse> TCourseCourseParentCourseCodeNavigations { get; set; } = new List<TCourseCourse>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguages { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseTrainingMaterial> TCourseTrainingMaterials { get; set; } = new List<TCourseTrainingMaterial>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TCourseTrainingResource> TCourseTrainingResources { get; set; } = new List<TCourseTrainingResource>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TJobCourse> TJobCourses { get; set; } = new List<TJobCourse>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TPersonWaitList> TPersonWaitLists { get; set; } = new List<TPersonWaitList>();

    [InverseProperty("CourseCodeNavigation")]
    public virtual ICollection<TTrainingProgramGroupCourse> TTrainingProgramGroupCourses { get; set; } = new List<TTrainingProgramGroupCourse>();

    [ForeignKey("TrainingProviderCode")]
    [InverseProperty("TCourses")]
    public virtual TTrainingProvider TrainingProviderCodeNavigation { get; set; } = null!;
}
