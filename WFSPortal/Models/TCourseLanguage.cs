using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseLanguage")]
public partial class TCourseLanguage
{
    [Key]
    [Column("CourseLanguageGUID")]
    public Guid CourseLanguageGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

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

    public bool PrerequisiteFlag { get; set; }

    public bool AchievementFlag { get; set; }

    public bool InactiveCodeFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseLanguages")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("TCourseLanguages")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TCourseLanguageReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TCourseLanguageSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TCourseLanguageTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TCourseLanguageWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
