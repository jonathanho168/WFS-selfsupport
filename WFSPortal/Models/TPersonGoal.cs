using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonGoal")]
public partial class TPersonGoal
{
    [Key]
    [Column("PersonGoalGUID")]
    public Guid PersonGoalGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AchievedDate { get; set; }

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

    [StringLength(80)]
    public string? CareerGoalDescription { get; set; }

    public string? CareerGoalDesires { get; set; }

    public string? CareerGoalExperiences { get; set; }

    [StringLength(15)]
    public string MobilityStatusCode { get; set; } = null!;

    public string? DesiredLocations { get; set; }

    [Column("CreatedByPersonGUID")]
    public Guid? CreatedByPersonGuid { get; set; }

    [Column("ShowInESSFlag")]
    public bool ShowInEssflag { get; set; }

    public bool IncludeOnPerformanceReviewFlag { get; set; }

    [StringLength(15)]
    public string PerformanceReviewPositionCode { get; set; } = null!;

    public string? SupervisorComments { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string GoalTypeCode { get; set; } = null!;

    public Guid? ParentPersonGoalGuid { get; set; }

    public bool? RequiredForParentGoal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeferredUntilDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? PercentageCompleted { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? TargetAmount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ActualAmount { get; set; }

    [Column("CorporateGoalGUID")]
    public Guid? CorporateGoalGuid { get; set; }

    public bool? AutoAchieveFlag { get; set; }

    public string? EmployeeComments { get; set; }

    public bool JobNeedFlag { get; set; }

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [StringLength(15)]
    public string GoalObjectiveCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? TargetPayoutAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ActualPayoutAmount { get; set; }

    [StringLength(15)]
    public string PayoutCurrencyCode { get; set; } = null!;

    [Column("ShowPayoutInESSFlag")]
    public bool ShowPayoutInEssflag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TrainingProgramEnrolledDate { get; set; }

    public string? OtherGoalDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayoutDate { get; set; }

    public bool ApprovedForPayoutFlag { get; set; }

    [Column("PersonOtherPayGUID")]
    public Guid? PersonOtherPayGuid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? GoalWeight { get; set; }

    [ForeignKey("CertificationCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CompetencyProficiencyCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TProficiency CompetencyProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CorporateGoalGuid")]
    [InverseProperty("TPersonGoals")]
    public virtual TCorporateGoal? CorporateGoal { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("CreatedByPersonGuid")]
    [InverseProperty("TPersonGoalCreatedByPeople")]
    public virtual TPerson? CreatedByPerson { get; set; }

    [ForeignKey("GoalObjectiveCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TGoalObjective GoalObjectiveCodeNavigation { get; set; } = null!;

    [ForeignKey("GoalTypeCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TGoalType GoalTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("ParentPersonGoal")]
    public virtual ICollection<TPersonGoal> InverseParentPersonGoal { get; set; } = new List<TPersonGoal>();

    [ForeignKey("LanguageCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TLanguage LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("MobilityStatusCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TMobilityStatus MobilityStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("ParentPersonGoalGuid")]
    [InverseProperty("InverseParentPersonGoal")]
    public virtual TPersonGoal? ParentPersonGoal { get; set; }

    [ForeignKey("PayoutCurrencyCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TCurrency PayoutCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("PerformanceReviewPositionCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TPosition PerformanceReviewPositionCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonGoalPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonOtherPayGuid")]
    [InverseProperty("TPersonGoals")]
    public virtual TPersonOtherPayHist? PersonOtherPay { get; set; }

    [ForeignKey("ReadingLanguageProficiencyCode")]
    [InverseProperty("TPersonGoalReadingLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency ReadingLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("SpokenLanguageProficiencyCode")]
    [InverseProperty("TPersonGoalSpokenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency SpokenLanguageProficiencyCodeNavigation { get; set; } = null!;

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonCertification> TPersonCertifications { get; set; } = new List<TPersonCertification>();

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHists { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonLanguage> TPersonLanguages { get; set; } = new List<TPersonLanguage>();

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonTrainingProgram> TPersonTrainingPrograms { get; set; } = new List<TPersonTrainingProgram>();

    [InverseProperty("PersonGoal")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TPersonGoals")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;

    [ForeignKey("TranslationLanguageProficiencyCode")]
    [InverseProperty("TPersonGoalTranslationLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency TranslationLanguageProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("WrittenLanguageProficiencyCode")]
    [InverseProperty("TPersonGoalWrittenLanguageProficiencyCodeNavigations")]
    public virtual TLanguageProficiency WrittenLanguageProficiencyCodeNavigation { get; set; } = null!;
}
