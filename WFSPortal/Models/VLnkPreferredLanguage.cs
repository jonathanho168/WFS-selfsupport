using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkPreferredLanguage
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string LanguageCode { get; set; } = null!;

    public bool? NativeLanguageFlag { get; set; }

    public bool? PreferredLanguageFlag { get; set; }

    [StringLength(15)]
    public string ReadingLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SpokenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string TranslationLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string WrittenLanguageProficiencyCode { get; set; } = null!;

    [Column("PersonLanguageGUID")]
    public Guid PersonLanguageGuid { get; set; }

    [StringLength(15)]
    public string EmployeeReadingLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string EmployeeSpokenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string EmployeeTranslationLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string EmployeeWrittenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SupervisorReadingLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SupervisorSpokenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SupervisorTranslationLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string SupervisorWrittenLanguageProficiencyCode { get; set; } = null!;

    [Column("SupervisorProficiencyAssessedByPersonGUID")]
    public Guid? SupervisorProficiencyAssessedByPersonGuid { get; set; }

    [StringLength(15)]
    public string OtherReadingLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string OtherSpokenLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string OtherTranslationLanguageProficiencyCode { get; set; } = null!;

    [StringLength(15)]
    public string OtherWrittenLanguageProficiencyCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LanguageAcquiredDate { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    public string? LanguageDescription { get; set; }
}
