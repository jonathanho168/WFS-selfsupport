using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCompetencyCategory")]
[Index("CompetencyCategoryGuid", Name = "RG_tCompetencyCategory", IsUnique = true)]
public partial class TCompetencyCategory
{
    [Key]
    [StringLength(15)]
    public string CompetencyCategoryCode { get; set; } = null!;

    [Column("CompetencyCategoryGUID")]
    public Guid CompetencyCategoryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CompetencyCategoryDescription { get; set; }

    [InverseProperty("CompetencyCategoryCodeNavigation")]
    public virtual ICollection<TCompetency> TCompetencies { get; set; } = new List<TCompetency>();
}
