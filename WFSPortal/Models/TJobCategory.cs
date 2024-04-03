using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobCategory")]
[Index("JobCategoryGuid", Name = "RG_tJobCategory", IsUnique = true)]
public partial class TJobCategory
{
    [Key]
    [StringLength(15)]
    public string JobCategoryCode { get; set; } = null!;

    [Column("JobCategoryGUID")]
    public Guid JobCategoryGuid { get; set; }

    public bool AllowSelfNominationsFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? JobCategoryDescription { get; set; }

    [InverseProperty("JobCategoryCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();
}
