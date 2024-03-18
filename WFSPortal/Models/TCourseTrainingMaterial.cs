using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseTrainingMaterial")]
public partial class TCourseTrainingMaterial
{
    [Key]
    [Column("CourseTrainingMaterialGUID")]
    public Guid CourseTrainingMaterialGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingMaterialCode { get; set; } = null!;

    public bool ShowOnCourseCatalogFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseTrainingMaterials")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingMaterialCode")]
    [InverseProperty("TCourseTrainingMaterials")]
    public virtual TTrainingMaterial TrainingMaterialCodeNavigation { get; set; } = null!;
}
