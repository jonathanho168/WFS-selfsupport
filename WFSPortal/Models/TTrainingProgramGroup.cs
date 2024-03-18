using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramGroup")]
public partial class TTrainingProgramGroup
{
    [Key]
    public Guid TrainingProgramGroupGuid { get; set; }

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    public int? MinCompletionCount { get; set; }

    public int Sequence { get; set; }

    public int RowVersion { get; set; }

    public string? TrainingProgramGroupName { get; set; }

    [InverseProperty("TrainingProgramGroup")]
    public virtual ICollection<TTrainingProgramGroupCourse> TTrainingProgramGroupCourses { get; set; } = new List<TTrainingProgramGroupCourse>();

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TTrainingProgramGroups")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
