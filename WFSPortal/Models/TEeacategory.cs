using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tEEACategory")]
public partial class TEeacategory
{
    [Key]
    [Column("EEACategoryCode")]
    [StringLength(15)]
    public string EeacategoryCode { get; set; } = null!;

    [Column("EEACategoryGuid")]
    public Guid EeacategoryGuid { get; set; }

    [Column("EEACategoryDescription")]
    public string? EeacategoryDescription { get; set; }

    [StringLength(15)]
    public string? SortOrder { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [InverseProperty("EeacategoryCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();
}
