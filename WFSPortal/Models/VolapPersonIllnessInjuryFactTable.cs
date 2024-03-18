using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VolapPersonIllnessInjuryFactTable
{
    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(125)]
    public string? FullName { get; set; }

    [Column("IncidentID")]
    [StringLength(80)]
    public string? IncidentId { get; set; }

    [StringLength(15)]
    public string? IncidentTypeCode { get; set; }

    [StringLength(30)]
    public string? CaseNumber { get; set; }

    [StringLength(15)]
    public string IllnessInjuryStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IllnessInjuryDate { get; set; }

    public int? IllnessInjuryYear { get; set; }

    public int? IllnessInjuryQuarter { get; set; }

    public int? IllnessInjuryMonth { get; set; }

    [StringLength(15)]
    public string OccupationalIllnessCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string RegularJobCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    [StringLength(125)]
    public string? Supervisor { get; set; }

    public bool StayedOvernight { get; set; }

    public bool CompletedShiftFlag { get; set; }

    public bool PreExistingConditionFlag { get; set; }

    public bool TerminationFlag { get; set; }

    public bool? PermanentTransferFlag { get; set; }

    public bool EmergencyRoomFlag { get; set; }

    public bool? ReportableFlag { get; set; }

    [StringLength(15)]
    public string? PositionCode { get; set; }

    public int? Age { get; set; }

    public int? NumberOfServiceYears { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? AnnualRate { get; set; }
}
