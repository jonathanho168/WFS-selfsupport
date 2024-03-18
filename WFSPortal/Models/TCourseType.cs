using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCourseType")]
[Index("CourseTypeGuid", Name = "RG_tCourseType", IsUnique = true)]
public partial class TCourseType
{
    [Key]
    [StringLength(15)]
    public string CourseTypeCode { get; set; } = null!;

    [Column("CourseTypeGUID")]
    public Guid CourseTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CourseTypeDescription { get; set; }

    [InverseProperty("CourseTypeCodeNavigation")]
    public virtual ICollection<TCourse> TCourses { get; set; } = new List<TCourse>();
}
