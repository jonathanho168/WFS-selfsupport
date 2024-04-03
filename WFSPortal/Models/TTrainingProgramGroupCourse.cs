using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramGroupCourse")]
public partial class TTrainingProgramGroupCourse
{
    [Key]
    public Guid TrainingProgramGroupCourseGuid { get; set; }

    public Guid TrainingProgramGroupGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    public bool IsCoreFlag { get; set; }

    public int Sequence { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TTrainingProgramGroupCourses")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramGroupGuid")]
    [InverseProperty("TTrainingProgramGroupCourses")]
    public virtual TTrainingProgramGroup TrainingProgramGroup { get; set; } = null!;
}
