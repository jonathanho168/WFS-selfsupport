using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingProgramCertification")]
[Index("TrainingProgramCode", "CertificationCode", Name = "AK_tTrainingProgramCertification", IsUnique = true)]
public partial class TTrainingProgramCertification
{
    [StringLength(15)]
    public string TrainingProgramCode { get; set; } = null!;

    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Key]
    public Guid TrainingProgramCertificationGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("CertificationCode")]
    [InverseProperty("TTrainingProgramCertifications")]
    public virtual TCertification CertificationCodeNavigation { get; set; } = null!;

    [ForeignKey("TrainingProgramCode")]
    [InverseProperty("TTrainingProgramCertifications")]
    public virtual TTrainingProgram TrainingProgramCodeNavigation { get; set; } = null!;
}
