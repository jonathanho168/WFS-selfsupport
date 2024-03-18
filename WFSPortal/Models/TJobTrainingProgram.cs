using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobTrainingProgram")]
[Index("JobCode", "TrainingProgramCode", "PositionCode", Name = "AK_tJobTrainingProgram", IsUnique = true)]
public partial class TJobTrainingProgram
{
    [Key]
    public Guid JobTrainingProgramGuid { get; set; }

    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    public int? MonthsToComplete { get; set; }

    [ForeignKey("JobCode")]
    [InverseProperty("TJobTrainingPrograms")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobTrainingPrograms")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TJobTrainingPrograms")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
