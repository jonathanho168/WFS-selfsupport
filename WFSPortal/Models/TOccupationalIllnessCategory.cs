using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tOccupationalIllnessCategory")]
[Index("OccupationalIllnessCategoryGuid", Name = "RG_tOccupationalIllnessCategory", IsUnique = true)]
public partial class TOccupationalIllnessCategory
{
    [Key]
    [StringLength(15)]
    public string OccupationalIllnessCategoryCode { get; set; } = null!;

    [Column("OccupationalIllnessCategoryGUID")]
    public Guid OccupationalIllnessCategoryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? OccupationalIllnessCategoryDescription { get; set; }

    [InverseProperty("OccupationalIllnessCategoryCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();
}
