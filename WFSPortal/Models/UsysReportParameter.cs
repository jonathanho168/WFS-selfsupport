using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysReportParameters")]
[Index("UserGuid", "ParameterName", Name = "AK_USysReportParameters", IsUnique = true)]
public partial class UsysReportParameter
{
    [Key]
    [Column("ReportParametersGUID")]
    public Guid ReportParametersGuid { get; set; }

    public Guid? UserGuid { get; set; }

    [StringLength(200)]
    public string ParameterName { get; set; } = null!;

    public string? ParameterValue { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysReportParameters")]
    public virtual UsysUser? User { get; set; }
}
