using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHowAcquired")]
[Index("HowAcquiredGuid", Name = "RG_tHowAcquired", IsUnique = true)]
public partial class THowAcquired
{
    [Key]
    [StringLength(15)]
    public string HowAcquiredCode { get; set; } = null!;

    [Column("HowAcquiredGUID")]
    public Guid HowAcquiredGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? HowAcquiredDescription { get; set; }

    [InverseProperty("HowAcquiredCodeNavigation")]
    public virtual ICollection<TPersonCompetencyHist> TPersonCompetencyHists { get; set; } = new List<TPersonCompetencyHist>();

    [InverseProperty("HowAcquiredCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();
}
