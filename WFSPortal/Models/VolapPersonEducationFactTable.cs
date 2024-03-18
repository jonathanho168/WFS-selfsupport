using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonEducationFactTable
{
    [Column("PersonEducationGUID")]
    public Guid PersonEducationGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string DegreeCode { get; set; } = null!;

    [StringLength(15)]
    public string MajorCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PersonEducationStartDate { get; set; }

    public int? EducationStartDateYear { get; set; }

    public int? EducationStartDateQuarter { get; set; }

    public int? EducationStartDateMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonEducationEndDate { get; set; }

    public int? EducationEndDateYear { get; set; }

    public int? EducationEndDateQuarter { get; set; }

    public int? EducationEndDateMonth { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CreditsCompleted { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CreditsRequired { get; set; }

    [StringLength(15)]
    public string EducationStatusCode { get; set; } = null!;

    [Column("GPA", TypeName = "decimal(10, 4)")]
    public decimal? Gpa { get; set; }

    public bool GraduateFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GraduationDate { get; set; }

    public int? GraduationYear { get; set; }

    public int? GraduationQuarter { get; set; }

    public int? GraduationMonth { get; set; }

    [StringLength(80)]
    public string? School { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
