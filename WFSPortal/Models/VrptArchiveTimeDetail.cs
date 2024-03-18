using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptArchiveTimeDetail
{
    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    public string? TimeTypeDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EnteredHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RevisedHours { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string LocationCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(15)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    [StringLength(15)]
    public string FunctionalAreaCode { get; set; } = null!;

    [StringLength(15)]
    public string RegionCode { get; set; } = null!;

    [StringLength(15)]
    public string SectionCode { get; set; } = null!;

    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    [StringLength(15)]
    public string OrganizationUnitCode { get; set; } = null!;

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? CalculatedHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EmployeeOverrideHours { get; set; }

    public string? RevisedByComments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeOverrideStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmployeeOverrideEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RevisedStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RevisedEndTime { get; set; }

    [StringLength(15)]
    public string PositionCode { get; set; } = null!;

    [Column("EmployeeID")]
    [StringLength(24)]
    public string? EmployeeId { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; } = null!;
}
