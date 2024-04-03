using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VOpenEnrollmentParameter
{
    [Column("OpenEnrollmentParametersGUID")]
    public Guid OpenEnrollmentParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? BeneficiaryLimit { get; set; }

    public string? BenefitSummaryContributionFrequency { get; set; }

    public string? ShowDifferencesFlag { get; set; }

    public string? SignaturesEnabledFlag { get; set; }

    public string? DeleteEnrollmentRecordsOnHistoryCreated { get; set; }
}
