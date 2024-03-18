using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tInstructor")]
[Index("InstructorGuid", Name = "RG_tInstructor", IsUnique = true)]
public partial class TInstructor
{
    [Key]
    [StringLength(15)]
    public string InstructorCode { get; set; } = null!;

    [StringLength(15)]
    public string TrainingProviderCode { get; set; } = null!;

    [Column("InstructorGUID")]
    public Guid InstructorGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? InstructorName { get; set; }

    [InverseProperty("PrimaryInstructorCodeNavigation")]
    public virtual ICollection<TClass> TClassPrimaryInstructorCodeNavigations { get; set; } = new List<TClass>();

    [InverseProperty("SecondaryInstructorCodeNavigation")]
    public virtual ICollection<TClass> TClassSecondaryInstructorCodeNavigations { get; set; } = new List<TClass>();

    [ForeignKey("TrainingProviderCode")]
    [InverseProperty("TInstructors")]
    public virtual TTrainingProvider TrainingProviderCodeNavigation { get; set; } = null!;
}
