using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramCompetency")]
[Index("TrainingProgramCode", "CompetencyCode", Name = "AK_tTrainingProgramCompetency", IsUnique = true)]
public partial class TTrainingProgramCompetency
{
    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Key]
    public Guid TrainingProgramCompetencyGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TTrainingProgramCompetencies")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ProficiencyCode")]
    [InverseProperty("TTrainingProgramCompetencies")]
    public virtual TProficiency ProficiencyCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TTrainingProgramCompetencies")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
