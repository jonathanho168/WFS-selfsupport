using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VSystemPerformanceParameter
{
    [Column("SystemPerformanceParametersGUID")]
    public Guid SystemPerformanceParametersGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("SystemPerformance_ShowTaskMenuOtherTaskSelections")]
    public string? SystemPerformanceShowTaskMenuOtherTaskSelections { get; set; }

    [Column("System_DisableCodeTableDoubleClick")]
    public string? SystemDisableCodeTableDoubleClick { get; set; }
}
