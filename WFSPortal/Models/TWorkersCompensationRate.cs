using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorkersCompensationRate")]
[Index("StateProvinceCode", "WorkersCompensationCode", Name = "AK_tWorkersCompensationRate", IsUnique = true)]
public partial class TWorkersCompensationRate
{
    [StringLength(15)]
    public string StateProvinceCode { get; set; } = null!;

    [StringLength(15)]
    public string WorkersCompensationCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Rate { get; set; }

    [Key]
    [Column("WorkersCompensationRateGUID")]
    public Guid WorkersCompensationRateGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("StateProvinceCode")]
    [InverseProperty("TWorkersCompensationRates")]
    public virtual TStateProvince StateProvinceCodeNavigation { get; set; } = null!;

    [ForeignKey("WorkersCompensationCode")]
    [InverseProperty("TWorkersCompensationRates")]
    public virtual TWorkersCompensation WorkersCompensationCodeNavigation { get; set; } = null!;
}
