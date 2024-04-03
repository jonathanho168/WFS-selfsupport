using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobLanguage")]
[Index("PositionCode", "JobCode", "LanguageCode", Name = "AK_tJobLanguage", IsUnique = true)]
public partial class TJobLanguage
{
    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

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

    public bool InactiveFlag { get; set; }

    [Key]
    [Column("JobLanguageGUID")]
    public Guid JobLanguageGuid { get; set; }

    public int RowVersion { get; set; }

    public int? MonthsToComplete { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TJobLanguages")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("TJobLanguages")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobLanguages")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TJobLanguageReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TJobLanguageSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TJobLanguageTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TJobLanguageWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
