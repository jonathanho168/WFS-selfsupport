using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VAlertParameter
{
    [Column("AlertParametersGUID")]
    public Guid AlertParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? AdminEmail { get; set; }

    public string? WindowDays { get; set; }

    public string? PurgeDays { get; set; }
}
