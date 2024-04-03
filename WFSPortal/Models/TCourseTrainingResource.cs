using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseTrainingResource")]
public partial class TCourseTrainingResource
{
    [Key]
    [Column("CourseTrainingResourceGUID")]
    public Guid CourseTrainingResourceGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingResourceCode { get; set; } = null!;

    public bool ShowOnCourseCatalogFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseTrainingResources")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingResourceCode")]
    [InverseProperty("TCourseTrainingResources")]
    public virtual TTrainingResource TrainingResourceCodeNavigation { get; set; } = null!;
}
