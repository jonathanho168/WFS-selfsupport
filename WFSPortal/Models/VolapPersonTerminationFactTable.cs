using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonTerminationFactTable
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(80)]
    public string? NextEmployerName { get; set; }

    [StringLength(15)]
    public string TerminationReasonCode { get; set; } = null!;

    public int? TerminationYear { get; set; }

    public int? TerminationQuarter { get; set; }

    public int? TerminationMonth { get; set; }

    [StringLength(15)]
    public string? EthnicGroupCode { get; set; }

    [StringLength(15)]
    public string? GenderCode { get; set; }

    public bool? ActiveFlag { get; set; }

    [StringLength(15)]
    public string? StatusCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    public int? HireDateYear { get; set; }

    public int? HireDateQuarter { get; set; }

    public int? HireDateMonth { get; set; }

    [StringLength(15)]
    public string? CompanyCode { get; set; }

    [StringLength(15)]
    public string? DepartmentCode { get; set; }

    [StringLength(15)]
    public string? LocationCode { get; set; }

    [StringLength(15)]
    public string? OrganizationUnitCode { get; set; }

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    [StringLength(125)]
    public string? Supervisor { get; set; }

    [StringLength(15)]
    public string? JobCode { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? FullTimeEquivalent { get; set; }

    public bool? PrimaryPositionFlag { get; set; }

    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string? EeocategoryCode { get; set; }

    [StringLength(15)]
    public string? CostCenterCode { get; set; }

    [StringLength(15)]
    public string? DivisionCode { get; set; }

    [StringLength(15)]
    public string? ProjectCode { get; set; }

    [StringLength(15)]
    public string? JobCategoryCode { get; set; }

    [StringLength(15)]
    public string? JobReasonCode { get; set; }

    [StringLength(15)]
    public string? GradeCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? MonthlyRate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
