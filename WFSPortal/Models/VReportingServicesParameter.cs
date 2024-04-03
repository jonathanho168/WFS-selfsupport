using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VReportingServicesParameter
{
    [Column("ReportingServicesParametersGUID")]
    public Guid ReportingServicesParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? Path { get; set; }

    public string? Domain { get; set; }

    public string? ProcessName { get; set; }
}
