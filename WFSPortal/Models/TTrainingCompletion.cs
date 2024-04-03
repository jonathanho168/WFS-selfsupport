using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingCompletion")]
[Index("TrainingCompletionGuid", Name = "RG_tTrainingCompletion", IsUnique = true)]
public partial class TTrainingCompletion
{
    [Key]
    [StringLength(15)]
    public string TrainingCompletionCode { get; set; } = null!;

    public bool PassedFlag { get; set; }

    [Column("TrainingCompletionGUID")]
    public Guid TrainingCompletionGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? TrainingCompletionDescription { get; set; }

    [InverseProperty("TrainingCompletionCodeNavigation")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();
}
