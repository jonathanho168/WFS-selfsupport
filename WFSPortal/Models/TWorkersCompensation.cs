using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tWorkersCompensation")]
[Index("WorkersCompensationGuid", Name = "RG_tWorkersCompensation", IsUnique = true)]
public partial class TWorkersCompensation
{
    [Key]
    [StringLength(15)]
    public string WorkersCompensationCode { get; set; } = null!;

    [StringLength(15)]
    public string WorkersCompensationCategoryCode { get; set; } = null!;

    [Column("WorkersCompensationGUID")]
    public Guid WorkersCompensationGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? WorkersCompensationDescription { get; set; }

    [InverseProperty("WorkersCompensationCodeNavigation")]
    public virtual ICollection<TJob> TJobs { get; set; } = new List<TJob>();

    [InverseProperty("WorkersCompensationCodeNavigation")]
    public virtual ICollection<TPersonIncident> TPersonIncidents { get; set; } = new List<TPersonIncident>();

    [InverseProperty("WorkersCompensationCodeNavigation")]
    public virtual ICollection<TWorkersCompensationRate> TWorkersCompensationRates { get; set; } = new List<TWorkersCompensationRate>();

    [ForeignKey("WorkersCompensationCategoryCode")]
    [InverseProperty("TWorkersCompensations")]
    public virtual TWorkersCompensationCategory WorkersCompensationCategoryCodeNavigation { get; set; } = null!;
}
