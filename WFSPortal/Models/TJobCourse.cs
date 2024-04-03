using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobCourse")]
[Index("JobCode", "CourseCode", "PositionCode", Name = "AK_tJobCourse", IsUnique = true)]
[Index("CourseCode", Name = "IX_tJobCourse_CourseCode")]
public partial class TJobCourse
{
    [StringLength(15)]
    public string JobCode { get; set; } = null!;

    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    public string? Comments { get; set; }

    public bool InactiveFlag { get; set; }

    [Key]
    [Column("JobCourseGUID")]
    public Guid JobCourseGuid { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    public int RowVersion { get; set; }

    public int? MonthsToComplete { get; set; }

    [ForeignKey("CourseCode")]
    [InverseProperty("TJobCourses")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("JobCode")]
    [InverseProperty("TJobCourses")]
    public virtual TJob JobCodeNavigation { get; set; } = null!;

    [ForeignKey("PositionCode")]
    [InverseProperty("TJobCourses")]
    public virtual TPosition PositionCodeNavigation { get; set; } = null!;
}
