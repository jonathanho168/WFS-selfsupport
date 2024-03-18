using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingResource")]
[Index("TrainingResourceGuid", Name = "RG_tTrainingResource", IsUnique = true)]
public partial class TTrainingResource
{
    [Key]
    [StringLength(15)]
    public string TrainingResourceCode { get; set; } = null!;

    public bool InactiveFlag { get; set; }

    [Column("TrainingResourceGUID")]
    public Guid TrainingResourceGuid { get; set; }

    public int RowVersion { get; set; }

    public string? TrainingResourceDescription { get; set; }

    [InverseProperty("TrainingResourceCodeNavigation")]
    public virtual ICollection<TClassTrainingResource> TClassTrainingResources { get; set; } = new List<TClassTrainingResource>();

    [InverseProperty("TrainingResourceCodeNavigation")]
    public virtual ICollection<TCourseTrainingResource> TCourseTrainingResources { get; set; } = new List<TCourseTrainingResource>();
}
