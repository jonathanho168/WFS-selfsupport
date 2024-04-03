using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProvider")]
[Index("TrainingProviderGuid", Name = "RG_tTrainingProvider", IsUnique = true)]
public partial class TTrainingProvider
{
    [Key]
    [StringLength(15)]
    public string TrainingProviderCode { get; set; } = null!;

    [Column("TrainingProviderGUID")]
    public Guid TrainingProviderGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? TrainingProviderDescription { get; set; }

    [InverseProperty("TrainingProviderCodeNavigation")]
    public virtual ICollection<TClass> TClasses { get; set; } = new List<TClass>();

    [InverseProperty("TrainingProviderCodeNavigation")]
    public virtual ICollection<TCourse> TCourses { get; set; } = new List<TCourse>();

    [InverseProperty("TrainingProviderCodeNavigation")]
    public virtual ICollection<TFacility> TFacilities { get; set; } = new List<TFacility>();

    [InverseProperty("TrainingProviderCodeNavigation")]
    public virtual ICollection<TInstructor> TInstructors { get; set; } = new List<TInstructor>();
}
