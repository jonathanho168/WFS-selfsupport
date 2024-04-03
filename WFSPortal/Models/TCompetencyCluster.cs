using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCompetencyCluster")]
[Index("CompetencyClusterGuid", Name = "RG_tCompetencyCluster", IsUnique = true)]
public partial class TCompetencyCluster
{
    [Key]
    [StringLength(15)]
    public string CompetencyClusterCode { get; set; } = null!;

    [Column("CompetencyClusterGUID")]
    public Guid CompetencyClusterGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CompetencyClusterDescription { get; set; }

    [InverseProperty("CompetencyClusterCodeNavigation")]
    public virtual ICollection<TCompetency> TCompetencies { get; set; } = new List<TCompetency>();
}
