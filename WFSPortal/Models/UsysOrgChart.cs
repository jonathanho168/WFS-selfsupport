using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysOrgChart")]
public partial class UsysOrgChart
{
    [Key]
    public Guid OrgChartGuid { get; set; }

    public Guid UserGuid { get; set; }

    [Column(TypeName = "image")]
    public byte[]? OrgChartData { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("UserGuid")]
    [InverseProperty("UsysOrgCharts")]
    public virtual UsysUser User { get; set; } = null!;
}
