using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VCodeFilteringParameter
{
    [Column("CodeFilteringParametersGUID")]
    public Guid CodeFilteringParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? EnabledFlag { get; set; }
}
