using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkTimeDetailAdp
{
    public Guid TimeDetailGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [Column("PersonID")]
    [StringLength(24)]
    public string? PersonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [StringLength(15)]
    public string TimeTypeCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? EnteredHours { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ApprovedFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentToPayrollDate { get; set; }

    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TimeGroupPeriodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeGroupPeriodEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeGroupPeriodGuid { get; set; }

    [StringLength(15)]
    public string? CompanyCode { get; set; }

    [StringLength(15)]
    public string CostCenterCode { get; set; } = null!;

    [StringLength(15)]
    public string? DivisionCode { get; set; }

    [StringLength(15)]
    public string? FunctionalAreaCode { get; set; }

    [StringLength(15)]
    public string? LocationCode { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public bool PrimaryPositionFlag { get; set; }

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string ProjectCode { get; set; } = null!;

    [StringLength(15)]
    public string? RegionCode { get; set; }

    [StringLength(15)]
    public string? SectionCode { get; set; }

    [StringLength(15)]
    public string? OvertimeStatusCode { get; set; }

    [StringLength(15)]
    public string PersonBasePayFrequencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PersonBasePayAmount { get; set; }
}
