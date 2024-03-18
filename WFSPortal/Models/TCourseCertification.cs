using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseCertification")]
public partial class TCourseCertification
{
    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    [Key]
    [Column("CourseCertificationGUID")]
    public Guid CourseCertificationGuid { get; set; }

    public bool InactiveCodeFlag { get; set; }

    public int RowVersion { get; set; }

    public bool AchievementFlag { get; set; }

    public bool PrerequisiteFlag { get; set; }

    [ForeignKey("CertificationCode")]
    [InverseProperty("TCourseCertifications")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCode")]
    [InverseProperty("TCourseCertifications")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;
}
