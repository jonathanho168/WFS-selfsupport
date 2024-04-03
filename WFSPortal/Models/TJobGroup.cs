using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tJobGroup")]
[Index("JobGroupGuid", Name = "RG_tJobGroup", IsUnique = true)]
public partial class TJobGroup
{
    [Key]
    [StringLength(15)]
    public string JobGroupCode { get; set; } = null!;

    [Column("JobGroupGUID")]
    public Guid JobGroupGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? JobGroupDescription { get; set; }

    [InverseProperty("JobGroupCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();
}
