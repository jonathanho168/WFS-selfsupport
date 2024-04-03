using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tClassTrainingResource")]
public partial class TClassTrainingResource
{
    [StringLength(15)]
    public string TrainingResourceCode { get; set; } = null!;

    [Column("ClassGUID")]
    public Guid ClassGuid { get; set; }

    [Key]
    [Column("ClassTrainingResourceGUID")]
    public Guid ClassTrainingResourceGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ClassGuid")]
    [InverseProperty("TClassTrainingResources")]
    public virtual TClass Class { get; set; } = null!;

    [ForeignKey("TrainingResourceCode")]
    [InverseProperty("TClassTrainingResources")]
    public virtual TTrainingResource TrainingResourceCodeNavigation { get; set; } = null!;
}
