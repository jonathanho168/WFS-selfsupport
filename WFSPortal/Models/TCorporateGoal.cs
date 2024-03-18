using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCorporateGoal")]
public partial class TCorporateGoal
{
    [Key]
    public Guid CorporateGoalGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    public int? Priority { get; set; }

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyProficiencyCode { get; set; } = null!;

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

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

    [Column("ShowInESSFlag")]
    public bool ShowInEssflag { get; set; }

    public bool IncludeOnPerformanceReviewFlag { get; set; }

    public string? Comments { get; set; }

    public bool InactiveFlag { get; set; }

    public int? RowVersion { get; set; }

    [StringLength(15)]
    public string GoalTypeCode { get; set; } = null!;

    public Guid? ParentCorporateGoalGuid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? TargetAmount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ActualAmount { get; set; }

    public bool? RequiredForParentGoalCompletionFlag { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageCompleted { get; set; }

    public bool? AutoAchieveFlag { get; set; }

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AchievedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeferredUntilDate { get; set; }

    public string? OtherGoalDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? TargetPayoutAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ActualPayoutAmount { get; set; }

    [StringLength(15)]
    public string PayoutCurrencyCode { get; set; } = null!;

    [Column("ShowPayoutInESSFlag")]
    public bool ShowPayoutInEssflag { get; set; }

    [Column(TypeName = "money")]
    public decimal? CorporateTargetAmount { get; set; }

    [StringLength(15)]
    public string GoalObjectiveCode { get; set; } = null!;

    [ForeignKey("CertificationCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyProficiencyCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TProficiency CompetencyProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("CreatedByPersonGuid")]
    [InverseProperty("TCorporateGoals")]
    public virtual TPerson? CreatedByPerson { get; set; }

    [ForeignKey("GoalObjectiveCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TGoalObjective GoalObjectiveCodeNavigation { get; set; } = null!;

    [ForeignKey("GoalTypeCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TGoalType GoalTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("ParentCorporateGoal")]
    public virtual ICollection<TCorporateGoal> InverseParentCorporateGoal { get; set; } = new List<TCorporateGoal>();

    [ForeignKey("LanguageCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("ParentCorporateGoalGuid")]
    [InverseProperty("InverseParentCorporateGoal")]
    public virtual TCorporateGoal? ParentCorporateGoal { get; set; }

    [ForeignKey("PayoutCurrencyCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TCurrency PayoutCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TCorporateGoalReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TCorporateGoalSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [InverseProperty("CorporateGoal")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TCorporateGoals")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TCorporateGoalTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TCorporateGoalWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
