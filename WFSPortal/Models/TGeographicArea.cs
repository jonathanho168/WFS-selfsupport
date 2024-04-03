using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGeographicArea")]
[Index("GeographicAreaGuid", Name = "RG_tGeographicArea", IsUnique = true)]
public partial class TGeographicArea
{
    [Key]
    [StringLength(15)]
    public string GeographicAreaCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal SurveyAdjustmentFactor { get; set; }

    [Column("GeographicAreaGUID")]
    public Guid GeographicAreaGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? GeographicAreaDescription { get; set; }

    [InverseProperty("GeographicAreaCodeNavigation")]
    public virtual ICollection<TSurveyDatum> TSurveyData { get; set; } = new List<TSurveyDatum>();

    [InverseProperty("GeographicAreaCodeNavigation")]
    public virtual ICollection<TSurveyFilterSetGeographicArea> TSurveyFilterSetGeographicAreas { get; set; } = new List<TSurveyFilterSetGeographicArea>();

    [InverseProperty("TargetGeographicAreaCodeNavigation")]
    public virtual ICollection<TSurveyFilterSet> TSurveyFilterSets { get; set; } = new List<TSurveyFilterSet>();
}
