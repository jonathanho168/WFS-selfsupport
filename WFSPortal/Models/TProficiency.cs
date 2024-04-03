using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tProficiency")]
[Index("ProficiencyGuid", Name = "RG_tProficiency", IsUnique = true)]
public partial class TProficiency
{
    [Key]
    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    public int? ProficiencyLevel { get; set; }

    [Column("ProficiencyGUID")]
    public Guid ProficiencyGuid { get; set; }

    [StringLength(15)]
    public string ScaleCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? ProficiencyDescription { get; set; }

    [ForeignKey("ScaleCode")]
    [InverseProperty("TProficiencies")]
    public virtual TScale ScaleCodeNavigation { get; set; } = null!;

    [InverseProperty("CompetencyProficiencyCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("ProficiencyCodeNavigation")]
    public virtual ICollection<TCourseCompetency> TCourseCompetencies { get; set; } = new List<TCourseCompetency>();

    [InverseProperty("ProficiencyCodeNavigation")]
    public virtual ICollection<TJobCompetency> TJobCompetencies { get; set; } = new List<TJobCompetency>();

    [InverseProperty("EmployeeProficiencyCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistEmployeeProficiencyCodeNavigations { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("OtherProficiencyCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistOtherProficiencyCodeNavigations { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("ProficiencyCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistProficiencyCodeNavigations { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("SupervisorProficiencyCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHistSupervisorProficiencyCodeNavigations { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("CompetencyProficiencyCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("GoalProficiencyCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestionAnswer> TPersonPerformanceQuestionAnswers { get; set; } = new List<TPersonPerformanceQuestionAnswer>();

    [InverseProperty("ProficiencyCodeNavigation")]
    public virtual ICollection<TTrainingProgramCompetency> TTrainingProgramCompetencies { get; set; } = new List<TTrainingProgramCompetency>();
}
