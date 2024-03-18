using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorkersCompensationCategory")]
[Index("WorkersCompensationCategoryGuid", Name = "RG_tWorkersCompensationCategory", IsUnique = true)]
public partial class TWorkersCompensationCategory
{
    [Key]
    [StringLength(15)]
    public string WorkersCompensationCategoryCode { get; set; } = null!;

    [Column("WorkersCompensationCategoryGUID")]
    public Guid WorkersCompensationCategoryGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? WorkersCompensationCategoryDescription { get; set; }

    [InverseProperty("WorkersCompensationCategoryCodeNavigation")]
    public virtual ICollection<TWorkersCompensation> TWorkersCompensations { get; set; } = new List<TWorkersCompensation>();
}
