using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tLanguageProficiency")]
[Index("LanguageProficiencyGuid", Name = "RG_tLanguageProficiency", IsUnique = true)]
public partial class TLanguageProficiency
{
    [Key]
    [StringLength(15)]
    public string LanguageProficiencyCode { get; set; } = null!;

    public int? LanguageProficiencyLevel { get; set; }

    [Column("LanguageProficiencyGUID")]
    public Guid LanguageProficiencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? LanguageProficiencyDescription { get; set; }

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoalReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoalSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoalTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoalWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguageReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguageSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguageTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TCourseLanguage> TCourseLanguageWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TCourseLanguage>();

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguageReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TJobLanguage>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguageSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TJobLanguage>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguageTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TJobLanguage>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguageWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TJobLanguage>();

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoalReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonGoal>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoalSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonGoal>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoalTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonGoal>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoalWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonGoal>();

    [InverseProperty("EmployeeReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageEmployeeReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("EmployeeSpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageEmployeeSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("EmployeeTranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageEmployeeTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("EmployeeWrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageEmployeeWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("OtherReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageOtherReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("OtherSpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageOtherSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("OtherTranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageOtherTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("OtherWrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageOtherWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SupervisorReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSupervisorReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SupervisorSpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSupervisorSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SupervisorTranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSupervisorTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("SupervisorWrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageSupervisorWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TPersonLanguage> TPersonLanguageWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("ReadingLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguageReadingLanguageProficiencyCodeNavigations { get; set; } = new List<TTrainingProgramLanguage>();

    [InverseProperty("SpokenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguageSpokenLanguageProficiencyCodeNavigations { get; set; } = new List<TTrainingProgramLanguage>();

    [InverseProperty("TranslationLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguageTranslationLanguageProficiencyCodeNavigations { get; set; } = new List<TTrainingProgramLanguage>();

    [InverseProperty("WrittenLanguageProficiencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguageWrittenLanguageProficiencyCodeNavigations { get; set; } = new List<TTrainingProgramLanguage>();
}
