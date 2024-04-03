using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPosition")]
[Index("PositionGuid", Name = "RG_tPosition", IsUnique = true)]
public partial class TPosition
{
    [Key]
    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("PositionGUID")]
    public Guid PositionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? PositionTitle { get; set; }

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobCertification> TJobCertifications { get; set; } = new List<TJobCertification>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobCompetency> TJobCompetencies { get; set; } = new List<TJobCompetency>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobCourse> TJobCourses { get; set; } = new List<TJobCourse>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobDescription> TJobDescriptions { get; set; } = new List<TJobDescription>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobLanguage> TJobLanguages { get; set; } = new List<TJobLanguage>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TJobTrainingProgram> TJobTrainingPrograms { get; set; } = new List<TJobTrainingProgram>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPerformanceQuestionPosition> TPerformanceQuestionPositions { get; set; } = new List<TPerformanceQuestionPosition>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonAbsenceHist> TPersonAbsenceHists { get; set; } = new List<TPersonAbsenceHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonBasePayHist> TPersonBasePayHists { get; set; } = new List<TPersonBasePayHist>();

    [InverseProperty("PerformanceReviewPositionCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonJobHist> TPersonJobHists { get; set; } = new List<TPersonJobHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonLocationHist> TPersonLocationHists { get; set; } = new List<TPersonLocationHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonNomination> TPersonNominations { get; set; } = new List<TPersonNomination>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonOtherPayHist> TPersonOtherPayHists { get; set; } = new List<TPersonOtherPayHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonOvertimeHist> TPersonOvertimeHists { get; set; } = new List<TPersonOvertimeHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonPerformanceHist> TPersonPerformanceHists { get; set; } = new List<TPersonPerformanceHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonProjectHist> TPersonProjectHists { get; set; } = new List<TPersonProjectHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonScheduleDate> TPersonScheduleDates { get; set; } = new List<TPersonScheduleDate>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonTimeDetail> TPersonTimeDetails { get; set; } = new List<TPersonTimeDetail>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupHist> TPersonTimeGroupHists { get; set; } = new List<TPersonTimeGroupHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPersonTimeGroupPeriod> TPersonTimeGroupPeriods { get; set; } = new List<TPersonTimeGroupPeriod>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPositionBudgetHist> TPositionBudgetHists { get; set; } = new List<TPositionBudgetHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHistPositionCodeNavigations { get; set; } = new List<TPositionHist>();

    [InverseProperty("ReportsToPositionCodeNavigation")]
    public virtual ICollection<TPositionHist> TPositionHistReportsToPositionCodeNavigations { get; set; } = new List<TPositionHist>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<TRequisition> TRequisitions { get; set; } = new List<TRequisition>();

    [InverseProperty("RecipientPositionCodeNavigation")]
    public virtual ICollection<UsysRecipient> UsysRecipients { get; set; } = new List<UsysRecipient>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetails { get; set; } = new List<UsysSalaryPlanBasePayPersonDetail>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetails { get; set; } = new List<UsysSalaryPlanOtherPayPersonDetail>();

    [InverseProperty("PositionCodeNavigation")]
    public virtual ICollection<UsysSalaryPlanPerson> UsysSalaryPlanPeople { get; set; } = new List<UsysSalaryPlanPerson>();
}
