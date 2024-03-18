using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTimeCostModelPersonDetail")]
[Index("TimeCostModelPersonDetailGuid", Name = "RG_USysTimeCostModelPersonDetail", IsUnique = true)]
public partial class UsysTimeCostModelPersonDetail
{
    [Key]
    [Column("TimeCostModelPersonDetailGUID")]
    public Guid TimeCostModelPersonDetailGuid { get; set; }

    [Column("TimeCostModelPersonGUID")]
    public Guid TimeCostModelPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PeriodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PeriodEndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ForecastedCost { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RevisedCost { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("TimeCostModelPersonGuid")]
    [InverseProperty("UsysTimeCostModelPersonDetails")]
    public virtual UsysTimeCostModelPerson TimeCostModelPerson { get; set; } = null!;
}
