using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonCompetencyFactTable
{
    [Column("PersonCompetencyGUID")]
    public Guid PersonCompetencyGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(15)]
    public string CompetencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CompetencyAcquiredDate { get; set; }

    public int? CompetencyAcquiredYear { get; set; }

    public int? CompetencyAcquiredQuarter { get; set; }

    public int? CompetencyAcquiredMonth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonCompetencyEndDate { get; set; }

    public int? CompetencyEndYear { get; set; }

    public int? CompetencyEndQuarter { get; set; }

    public int? CompetencyEndMonth { get; set; }

    public bool PersonCompetencyCurrentFlag { get; set; }

    [StringLength(15)]
    public string HowAcquiredCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CompetencyLastUsedDate { get; set; }

    public int? LastUsedYear { get; set; }

    public int? LastUsedQuarter { get; set; }

    public int? LastUsedMonth { get; set; }

    [StringLength(15)]
    public string ProficiencyCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ProficiencyEffectiveDate { get; set; }

    public int? ProficiencyEffectiveYear { get; set; }

    public int? ProficiencyEffectiveQuarter { get; set; }

    public int? ProficiencyEffectiveMonth { get; set; }

    [StringLength(15)]
    public string? ScaleCode { get; set; }

    [StringLength(15)]
    public string? CompetencyClusterCode { get; set; }

    [StringLength(15)]
    public string? CompetencyCategoryCode { get; set; }

    [StringLength(80)]
    public string? CompetencyAuthority { get; set; }

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
