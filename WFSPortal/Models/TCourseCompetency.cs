using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseCompetency")]
public partial class TCourseCompetency
{
    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [Key]
    [Column("CourseCompetencyGUID")]
    public Guid CourseCompetencyGuid { get; set; }

    public bool InactiveCodeFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    public bool AchievementFlag { get; set; }

    public bool PrerequisiteFlag { get; set; }

    [ForeignKey("CompetencyCode")]
    [InverseProperty("TCourseCompetencies")]
    public virtual TCompetency CompetencyCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseCompetencies")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("ProficiencyCode")]
    [InverseProperty("TCourseCompetencies")]
    public virtual TProficiency ProficiencyCodeNavigation { get; set; } = null!;
}
