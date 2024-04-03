using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLanguage")]
[Index("LanguageGuid", Name = "RG_tLanguage", IsUnique = true)]
public partial class TLanguage
{
    [Key]
    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    [Column("LanguageGUID")]
    public Guid LanguageGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public byte[]? FlagImage { get; set; }

    public string? LanguageDescription { get; set; }

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguages { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguages { get; set; } = new List<TJobLanguage>();

    [InverseProperty("PrimaryLanguageCodeNavigation")]
    public virtual ICollection<TPerson> TPeople { get; set; } = new List<TPerson>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TPerformanceQuestion> TPerformanceQuestions { get; set; } = new List<TPerformanceQuestion>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguages { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TPersonOtherName> TPersonOtherNames { get; set; } = new List<TPersonOtherName>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestionLanguageCodeNavigations { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("QuestionLanguageCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestionQuestionLanguageCodeNavigations { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguages { get; set; } = new List<TTrainingProgramLanguage>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<UsysColumnTranslation> UsysColumnTranslations { get; set; } = new List<UsysColumnTranslation>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<UsysLanguageUser> UsysLanguageUsers { get; set; } = new List<UsysLanguageUser>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<UsysResource> UsysResources { get; set; } = new List<UsysResource>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<UsysUser> UsysUsers { get; set; } = new List<UsysUser>();
}
