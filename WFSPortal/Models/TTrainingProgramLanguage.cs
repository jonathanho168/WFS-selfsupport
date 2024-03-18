using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramLanguage")]
[Index("TrainingProgramCode", "LanguageCode", Name = "AK_tTrainingProgramLanguage", IsUnique = true)]
public partial class TTrainingProgramLanguage
{
    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    [StringLength(15)]
    public string ReadingLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SpokenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string TranslationLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string WrittenLanguageProficiencyCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Key]
    public Guid TrainingProgramLanguageGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("LanguageCode")]
    [InverseProperty("TTrainingProgramLanguages")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TTrainingProgramLanguageReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TTrainingProgramLanguageSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TTrainingProgramLanguages")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TTrainingProgramLanguageTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TTrainingProgramLanguageWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
