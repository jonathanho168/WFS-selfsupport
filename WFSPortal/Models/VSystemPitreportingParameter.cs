using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VSystemPitreportingParameter
{
    [Column("SystemPITReportingParametersGUID")]
    public Guid SystemPitreportingParametersGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("PITDate")]
    public string? Pitdate { get; set; }
}
