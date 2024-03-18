using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VAbsencePointsParameter
{
    [Column("AbsencePointsParametersGUID")]
    public Guid AbsencePointsParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? EarnIterativelyPeriod { get; set; }

    public string? MaxPoints { get; set; }

    public string? BeginningBalance { get; set; }

    public string? ResetIterativelyPeriodFrequencyCode { get; set; }

    public string? IncreasesPointsFlag { get; set; }

    public string? EarnIterativelyPeriodFrequencyCode { get; set; }

    public string? EarnDate { get; set; }

    public string? EarnPeriod { get; set; }

    public string? ResetPeriod { get; set; }

    public string? AbsencePointSystemEnabled { get; set; }

    public string? ResetIterativelyPeriod { get; set; }

    public string? EarnPoints { get; set; }

    public string? MinPoints { get; set; }

    public string? ResetDate { get; set; }
}
