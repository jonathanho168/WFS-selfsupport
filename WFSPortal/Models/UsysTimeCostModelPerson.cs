using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysTimeCostModelPerson")]
[Index("TimeCostModelPersonGuid", Name = "RG_USysTimeCostModelPerson", IsUnique = true)]
public partial class UsysTimeCostModelPerson
{
    [Key]
    [Column("TimeCostModelPersonGUID")]
    public Guid TimeCostModelPersonGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string? TimeCostModelCode { get; set; }

    [StringLength(15)]
    public string TimeGroupCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? BaseCost { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ForecastedCost { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RevisedCost { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonGuid")]
    [InverseProperty("UsysTimeCostModelPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("TimeCostModelCode")]
    [InverseProperty("UsysTimeCostModelPeople")]
    public virtual UsysTimeCostModel? TimeCostModelCodeNavigation { get; set; }

    [ForeignKey("TimeGroupCode")]
    [InverseProperty("UsysTimeCostModelPeople")]
    public virtual TTimeGroup TimeGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("TimeCostModelPerson")]
    public virtual ICollection<UsysTimeCostModelPersonDetail> UsysTimeCostModelPersonDetails { get; set; } = new List<UsysTimeCostModelPersonDetail>();
}
