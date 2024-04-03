using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tIndustrySector")]
[Index("IndustrySectorGuid", Name = "RG_tIndustrySector", IsUnique = true)]
public partial class TIndustrySector
{
    [Key]
    [StringLength(15)]
    public string IndustrySectorCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal SurveyAdjustmentFactor { get; set; }

    [Column("IndustrySectorGUID")]
    public Guid IndustrySectorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? IndustrySectorDescription { get; set; }

    [InverseProperty("IndustrySectorCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("IndustrySectorCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetIndustrySector> TSurveyFilterSetIndustrySectors { get; set; } = new List<TSurveyFilterSetIndustrySector>();
}
