using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramTrainingProgram")]
public partial class TTrainingProgramTrainingProgram
{
    [Key]
    [Column("TrainingProgramTrainingProgramGUID")]
    public Guid TrainingProgramTrainingProgramGuid { get; set; }

    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [StringLength(15)]
    public string ParentTrainingProgramCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ParentTrainingProgramCode")]
    [InverseProperty("TTrainingProgramTrainingProgramParentTrainingProgramCodeNavigations")]
    public virtual TTrainingProgram ParentTrainingProgramCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TTrainingProgramTrainingProgramTrainingProgramCodeNavigations")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
