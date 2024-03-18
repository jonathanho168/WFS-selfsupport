using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEEOCategory")]
[Index("EeocategoryGuid", Name = "RG_tEEOCategory", IsUnique = true)]
public partial class TEeocategory
{
    [Key]
    [Column("EEOCategoryCode")]
    [StringLength(15)]
    public string EeocategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string? SortOrder { get; set; }

    [Column("EEOCategoryGUID")]
    public Guid EeocategoryGuid { get; set; }

    [Column("EOSurveySortOrder")]
    [StringLength(15)]
    public string? EosurveySortOrder { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("EEOCategoryDescription")]
    public string? EeocategoryDescription { get; set; }

    [InverseProperty("EeocategoryCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();
}
