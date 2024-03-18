using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTimeCostModel")]
[Index("TimeCostModelGuid", Name = "RG_USysTimeCostModel")]
public partial class UsysTimeCostModel
{
    [Column("TimeCostModelGUID")]
    public Guid TimeCostModelGuid { get; set; }

    [Key]
    [StringLength(15)]
    public string TimeCostModelCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ForecastHours { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ForecastPercentage { get; set; }

    public bool ForecastDailyFlag { get; set; }

    [StringLength(15)]
    public string CurrencyCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? TimeCostModelDescription { get; set; }

    [ForeignKey("CurrencyCode")]
    [InverseProperty("UsysTimeCostModels")]
    public virtual TCurrency CurrencyCodeNavigation { get; set; } = null!;

    [InverseProperty("TimeCostModelCodeNavigation")]
    public virtual ICollection<UsysTimeCostModelPerson> UsysTimeCostModelPeople { get; set; } = new List<UsysTimeCostModelPerson>();
}
