using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcTimeGroup")]
public partial class DcTimeGroup
{
    [StringLength(50)]
    [Unicode(false)]
    public string? TimeGroupCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TimeGroupDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimesheetEntryMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LocationCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DepartmentCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CompanyCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DivisionCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FunctionalAreaCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CostCenterCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegionCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SectionCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnitCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShiftCodeFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AllowClockInOutOverrideFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HolidayTimeTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AutoGenFrequencyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AutoGenDaysInAdvance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AutoGenStartDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DefaultOvertimeRuleCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AllowEmployeeNewRecordEntryFlag { get; set; }

    [Column("OTSchedule")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Otschedule { get; set; }
}
