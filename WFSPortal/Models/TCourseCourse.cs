using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseCourse")]
public partial class TCourseCourse
{
    [Key]
    [Column("CourseCourseGUID")]
    public Guid CourseCourseGuid { get; set; }

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string ParentCourseCode { get; set; } = null!;

    public bool PrerequisiteFlag { get; set; }

    public bool AchievementFlag { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveCodeFlag { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseCourseCourseCodeNavigations")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("ParentCourseCode")]
    [InverseProperty("TCourseCourseParentCourseCodeNavigations")]
    public virtual TCourse ParentCourseCodeNavigation { get; set; } = null!;
}
