using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTrainingProgram")]
public partial class TPersonTrainingProgram
{
    [Key]
    public Guid PersonTrainingProgramGuid { get; set; }

    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EnrolledDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProgramDroppedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProgramCompletedDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonGoalGUID")]
    public Guid? PersonGoalGuid { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonTrainingPrograms")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("PersonGoalGuid")]
    [InverseProperty("TPersonTrainingPrograms")]
    public virtual TPersonGoal? PersonGoal { get; set; }

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TPersonTrainingPrograms")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
