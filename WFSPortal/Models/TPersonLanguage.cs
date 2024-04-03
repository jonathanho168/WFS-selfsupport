using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonLanguage")]
public partial class TPersonLanguage
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

    [Key]
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

    [ForeignKey("EmployeeReadingLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageEmployeeReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency EmployeeReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployeeSpokenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageEmployeeSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency EmployeeSpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployeeTranslationLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageEmployeeTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency EmployeeTranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("EmployeeWrittenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageEmployeeWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency EmployeeWrittenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("TPersonLanguages")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherReadingLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageOtherReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency OtherReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherSpokenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageOtherSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency OtherSpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherTranslationLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageOtherTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency OtherTranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("OtherWrittenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageOtherWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency OtherWrittenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonLanguagePeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonLanguages")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorProficiencyAssessedByPersonGuid")]
    [InverseProperty("TPersonLanguageSupervisorProficiencyAssessedByPeople")]
    public virtual TPerson? SupervisorProficiencyAssessedByPerson { get; set; }

    [ForeignKey("SupervisorReadingLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageSupervisorReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SupervisorReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorSpokenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageSupervisorSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SupervisorSpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorTranslationLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageSupervisorTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SupervisorTranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorWrittenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageSupervisorWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SupervisorWrittenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TPersonLanguageWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
