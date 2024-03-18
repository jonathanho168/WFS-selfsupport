using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLeaveParameter
{
    [Column("LeaveParametersGUID")]
    public Guid LeaveParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? PtoOptionalSickFlag { get; set; }

    public string? PtoRequiredOtherFlag { get; set; }

    public string? LeaveBalanceAlertPoint { get; set; }

    public string? FmlaShowBalanceInEss { get; set; }

    public string? FmlaAccrualMethod { get; set; }

    public string? PtoOptionalVacationFlag { get; set; }

    public string? HealthPremiumContactName { get; set; }

    public string? EligibilityFormsDueDays { get; set; }

    public string? PtoOptionalOtherFlag { get; set; }

    public string? HealthPremiumDueFlag { get; set; }

    public string? PtoRequiredSickFlag { get; set; }

    public string? PtoRequiredVacationFlag { get; set; }

    public string? IntentToReturnToWorkRequirementIntervalFlag { get; set; }

    public string? FmlaAccrualMethodFixedDate { get; set; }

    public string? PtoOptionalFlag { get; set; }

    public string? FmlaCureDays { get; set; }

    public string? PtoRequiredFlag { get; set; }

    public string? HealthPremiumContactLocation { get; set; }

    public string? FmlaCertificationDays { get; set; }
}
