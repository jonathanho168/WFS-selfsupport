using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VAcaparameter
{
    [Column("ACAParametersGUID")]
    public Guid AcaparametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? MainlandSingleFederalPovertyLine { get; set; }

    public string? NumberofDaystoOptOutAutoEnrolledCoverage { get; set; }

    public string? FullTimeStatusCategoryExclusions { get; set; }
}
