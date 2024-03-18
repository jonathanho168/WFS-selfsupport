using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgram")]
[Index("TrainingProgramGuid", Name = "AK_tTrainingProgram", IsUnique = true)]
public partial class TTrainingProgram
{
    [Key]
    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [StringLength(255)]
    public string? ProgramUrl { get; set; }

    public Guid TrainingProgramGuid { get; set; }

    public int RowVersion { get; set; }

    public string? ProgramSummary { get; set; }

    public string? TrainingProgramDescription { get; set; }

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TJobTrainingProgram> TJobTrainingPrograms { get; set; } = new List<TJobTrainingProgram>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TPersonTrainingProgram> TPersonTrainingPrograms { get; set; } = new List<TPersonTrainingProgram>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramCertification> TTrainingProgramCertifications { get; set; } = new List<TTrainingProgramCertification>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramCompetency> TTrainingProgramCompetencies { get; set; } = new List<TTrainingProgramCompetency>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramGroup> TTrainingProgramGroups { get; set; } = new List<TTrainingProgramGroup>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramLanguage> TTrainingProgramLanguages { get; set; } = new List<TTrainingProgramLanguage>();

    [InverseProperty("ParentTrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramTrainingProgram> TTrainingProgramTrainingProgramParentTrainingProgramCodeNavigations { get; set; } = new List<TTrainingProgramTrainingProgram>();

    [InverseProperty("TrainingProgramCodeNavigation")]
    public virtual ICollection<TTrainingProgramTrainingProgram> TTrainingProgramTrainingProgramTrainingProgramCodeNavigations { get; set; } = new List<TTrainingProgramTrainingProgram>();
}
