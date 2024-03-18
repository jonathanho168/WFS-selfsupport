using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VTimesheetParameter
{
    [Column("TimesheetParametersGUID")]
    public Guid TimesheetParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? AddAbsencePlanHolidaysDays { get; set; }

    public string? TimesheetDashboardTooltipCount { get; set; }

    public string? TimeOffRequestTimeTypeLimits { get; set; }

    public string? AddAbsencePlanHolidays { get; set; }
}
