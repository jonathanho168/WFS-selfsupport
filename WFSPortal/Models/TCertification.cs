using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCertification")]
[Index("CertificationGuid", Name = "RG_tCertification", IsUnique = true)]
public partial class TCertification
{
    [Key]
    [StringLength(15)]
    public string CertificationCode { get; set; } = null!;

    [Column("CertificationGUID")]
    public Guid CertificationGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? CertificationDescription { get; set; }

    [StringLength(15)]
    public string CertificationTypeCode { get; set; } = null!;

    [ForeignKey("CertificationTypeCode")]
    [InverseProperty("TCertifications")]
    public virtual TCertificationType CertificationTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TCorporateGoal> TCorporateGoals { get; set; } = new List<TCorporateGoal>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TCourseCertification> TCourseCertifications { get; set; } = new List<TCourseCertification>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TJobCertification> TJobCertifications { get; set; } = new List<TJobCertification>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TPersonCertification> TPersonCertifications { get; set; } = new List<TPersonCertification>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TPersonGoal> TPersonGoals { get; set; } = new List<TPersonGoal>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; } = new List<TPersonPerformanceQuestion>();

    [InverseProperty("CertificationCodeNavigation")]
    public virtual ICollection<TTrainingProgramCertification> TTrainingProgramCertifications { get; set; } = new List<TTrainingProgramCertification>();
}
