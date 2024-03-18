using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonEducationHist")]
[Index("School", Name = "IX_tPersonEducationHist")]
public partial class TPersonEducationHist
{
    [Key]
    [Column("PersonEducationGUID")]
    public Guid PersonEducationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEducationStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEducationEndDate { get; set; }

    [StringLength(15)]
    public string DegreeCode { get; set; } = null!;

    [StringLength(15)]
    public string MajorCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CreditsCompleted { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CreditsRequired { get; set; }

    [StringLength(15)]
    public string EducationStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedGraduationDate { get; set; }

    [Column("GPA", TypeName = "decimal(10, 4)")]
    public decimal? Gpa { get; set; }

    [Column("GPAScale", TypeName = "decimal(10, 4)")]
    public decimal? Gpascale { get; set; }

    public bool GraduateFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GraduationDate { get; set; }

    [StringLength(80)]
    public string? School { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("DegreeCode")]
    [InverseProperty("TPersonEducationHists")]
    public virtual TDegree DegreeCodeNavigation { get; set; } = null!;

    [ForeignKey("EducationStatusCode")]
    [InverseProperty("TPersonEducationHists")]
    public virtual TEducationStatus EducationStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("MajorCode")]
    [InverseProperty("TPersonEducationHists")]
    public virtual TMajor MajorCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonEducationHists")]
    public virtual TPerson Person { get; set; } = null!;
}
